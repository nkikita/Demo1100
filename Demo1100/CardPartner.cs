using Demo1100.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1100
{
    public partial class CardPartner : UserControl
    {
        PartnersDemo _partner;
        ApplictionDbContext _context;
        public event Action<PartnersDemo> OnPartnerChanged;
        public CardPartner(ApplictionDbContext context)
        {
            InitializeComponent();
            Click += CardPartner_Click;
            _context = context;
        }

        public void CardPartner_Click(object sender, EventArgs e)
        {
            OnPartnerChanged.Invoke(_partner);
        }

        public decimal GetFullPrice(int partId)
        {
            return _context.Story
                .Where(p => p.Id_part_story == partId)
                .Sum(p => p.Count_story_prod);
        }

        public static int SaleCount(decimal summ)
        {
            if (summ >= 300000) return 15;
            if (summ >= 50000) return 10;
            if (summ >= 10000) return 5;
            return 0;
        }

        private void CardPartner_Load(object sender, EventArgs e)
        {

        }
        public void SetData(PartnersDemo partner)
        {
            _partner = partner;

            var sum = GetFullPrice(partner.Id_partner);
            var sale = SaleCount(sum);

            SaleL.Text = "Скидка: "+ sale;

            NameL.Text = partner.Name_partner;
            TypeL.Text = partner.typesDemo.Name_type;
            DirektorL.Text = partner.direktorsDemo.FullName;
            PhoneL.Text = partner.Phone_pertner.ToString();
            RankL.Text = "Ранг: " + partner.Rank_pertner.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new StoryForm(_context, _partner.Id_partner);
            form.ShowDialog();
        }
    }
}
