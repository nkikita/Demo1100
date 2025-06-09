using Demo1100.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo1100
{

    public partial class MainForm : Form
    {
        ApplictionDbContext _context;
        public MainForm()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            _context = new ApplictionDbContext();
        }

        public async Task<List<PartnersDemo>> LoadFromDb()
        {
            return await _context.Partners
                .Include(p => p.direktorsDemo)
                .Include(t => t.typesDemo)
                .ToListAsync();
        }

        public async Task RefereshData()
        {
            flowLayoutPanel1.Controls.Clear();
            var data = await LoadFromDb();
            foreach (var item in data)
            {
                var card = new CardPartner(_context);
                card.SetData(item);
                card.OnPartnerChanged += EditFormOp;
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await RefereshData();
        }

        public async void EditFormOp(PartnersDemo partners)
        {
            try
            {
                var freshPart = await _context.Partners
                    .Include(p => p.adressDemo)
                    .Include(t => t.typesDemo)
                    .Include(p => p.direktorsDemo)
                    .FirstOrDefaultAsync(p => p.Id_partner == partners.Id_partner);

                var Editform = new EditPartnerForm(_context, freshPart);
                if (Editform.ShowDialog() == DialogResult.OK)
                {
                    await RefereshData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: "+ ex);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var forma = new AddPartnerForm(_context);;
            if (forma.ShowDialog() == DialogResult.OK)
            {
                await RefereshData();
            }
        }
    }

    public class ApplictionDbContext : DbContext 
    {
        public DbSet<DirektorsDemo> Direktors { get; set; }
        public DbSet<TypesDemo> Types { get; set; }
        public DbSet<AdressDemo> Adress { get; set; }
        public DbSet<PartnersDemo> Partners { get; set; }
        public DbSet<StoryDemo> Story { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Demo;Username=sus;Password=11");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
