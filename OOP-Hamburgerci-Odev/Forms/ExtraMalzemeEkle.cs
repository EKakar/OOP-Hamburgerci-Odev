using OOP_Hamburgerci_Odev.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci_Odev
{
    public partial class extraMalzeme : Form
    {
        public extraMalzeme()
        {
            InitializeComponent();
        }
        ExtraMalzemeler extra;
        public List<ExtraMalzemeler> malzemeler;


        private void extraMalzeme_Load(object sender, EventArgs e)
        {
            btnExtraMalzeme.Enabled = false;
        }

        private void txtMenüAdı_TextChanged(object sender, EventArgs e)
        {
            btnExtraMalzeme.Enabled = true;
        }

        private void btnExtraMalzeme_Click(object sender, EventArgs e)
        {
            extra = new ExtraMalzemeler();
            extra.Adı = txtMenüAdı.Text;
            extra.MalzemeFiyati = (double)numericUpDown1.Value;


            malzemeler.Add(extra);

            MessageBox.Show($"{extra.Adı} Malzemelere Başarıyla Eklendi");
            txtMenüAdı.Text = string.Empty;
            numericUpDown1.Value = default;
        }


    }
}
