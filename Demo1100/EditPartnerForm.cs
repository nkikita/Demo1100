using Accessibility;
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
    public partial class EditPartnerForm : Form
    {
        ApplictionDbContext _context;
        public PartnersDemo _partner;
        public EditPartnerForm(ApplictionDbContext context, PartnersDemo partner)
        {
            InitializeComponent();
            _context = context;
            _partner = partner;
            LoadData();
        }

        public void LoadData()
        {
            var types = _context.Types.ToList();
            comboBox1.DataSource = types;
            comboBox1.ValueMember = "Id_type";
            comboBox1.DisplayMember = "Name_type";
            comboBox1.SelectedValue = _partner.Type_partner;

            InntextBox5.Text = Convert.ToString(_partner.Inn_partner);
            FIOtextBox2.Text = _partner.direktorsDemo.FullName;
            PhonetextBox4.Text = _partner.Phone_pertner;
            RanktextBox6.Text = Convert.ToString(_partner.Rank_pertner);
            EmailtextBox3.Text = _partner.Email_partner;
            NametextBox1.Text = _partner.Name_partner;

            OblasttextBox11.Text = _partner.adressDemo.State_adress;
            StreettextBox9.Text = _partner.adressDemo.Street_adress;
            HometextBox8.Text =  Convert.ToString(_partner.adressDemo.Home_adress);
            TowntextBox10.Text = _partner.adressDemo.Town_adress;
            IndextextBox7.Text = Convert.ToString(_partner.adressDemo.Index_adress);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var text = FIOtextBox2.Text.Split(' ');
            _partner.direktorsDemo.Fam_direktor = text[0];
            _partner.direktorsDemo.Name_direktor = text[1];
            _partner.direktorsDemo.Otch_direktor = text[2];
            _context.Direktors.Update(_partner.direktorsDemo);


            _partner.adressDemo.State_adress = OblasttextBox11.Text;
            _partner.adressDemo.Home_adress = Convert.ToInt32(HometextBox8.Text);
            _partner.adressDemo.Street_adress = StreettextBox9.Text;
            _partner.adressDemo.Index_adress = Convert.ToInt64(IndextextBox7.Text);
            _partner.adressDemo.Town_adress = TowntextBox10.Text;
            _context.Adress.Update(_partner.adressDemo);

            _partner.Rank_pertner = Convert.ToInt32(RanktextBox6.Text);
            _partner.Type_partner = (int)Convert.ToInt32(comboBox1.SelectedValue);
            _partner.Email_partner = EmailtextBox3.Text;
            _partner.Phone_pertner = PhonetextBox4.Text;
            _partner.Name_partner = NametextBox1.Text;
            _partner.Inn_partner = Convert.ToInt64(InntextBox5.Text);
            _context.Partners.Update(_partner);

            await _context.SaveChangesAsync();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditPartnerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
