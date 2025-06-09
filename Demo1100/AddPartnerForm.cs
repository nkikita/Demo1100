using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1100.Models
{
    public partial class AddPartnerForm : Form
    {
        ApplictionDbContext _context;
        public AddPartnerForm(ApplictionDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadCb();
        }

        public void LoadCb()
        {
            var types = _context.Types.ToList();
            comboBox1.DataSource = types;
            comboBox1.ValueMember = "Id_type";
            comboBox1.DisplayMember = "Name_type";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var text = FIOtextBox2.Text.Split(' ');
            var direktor = new DirektorsDemo
            {
                Fam_direktor = text[0],
                Name_direktor = text[1],
                Otch_direktor= text[2],
            };
            _context.Direktors.Add(direktor);
            await _context.SaveChangesAsync();

            var adress = new AdressDemo
            {
                State_adress = OblasttextBox11.Text,
                Town_adress = TowntextBox10.Text,
                Street_adress = StreettextBox9.Text,
                Home_adress = Convert.ToInt32(HometextBox8.Text),
                Index_adress = Convert.ToInt32(IndextextBox7.Text)
            };
            _context.Adress.Add(adress);
            await _context.SaveChangesAsync();

            var partner = new PartnersDemo
            {
                Direktor_partner = direktor.Id_direkor,
                Adress_partner = adress.Id_adress,

                Type_partner = (int)comboBox1.SelectedValue,
                Name_partner = NametextBox1.Text,
                Inn_partner = Convert.ToInt32(InntextBox5.Text),
                Email_partner = EmailtextBox3.Text,
                Phone_pertner = PhonetextBox4.Text,
                Rank_pertner = Convert.ToInt32(RanktextBox6.Text)
            };
            _context.Partners.Add(partner);
            await _context.SaveChangesAsync();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddPartnerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
