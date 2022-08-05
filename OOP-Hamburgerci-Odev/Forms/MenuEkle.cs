using OOP_Hamburgerci_Odev.Concrete;
using OOP_Hamburgerci_Odev.Enums;
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
    public partial class menuEkle : Form
    {
        Menu m;
        public List<Menu> menuler;

        public menuEkle()
        {
            InitializeComponent();
        }

        private void menuEkle_Load(object sender, EventArgs e)
        {
            btnMenuKaydet.Enabled = false;
        }

        private void txtMenüAdı_TextChanged(object sender, EventArgs e)
        {
            btnMenuKaydet.Enabled = true;
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            m = new Menu()
            {
                MenuAdı = txtMenüAdı.Text.Trim().ToString(),
                Fiyati = (double)numericUpDown1.Value,
                boyut = Boyut.Küçük
            };

            menuler.Add(m);

            MessageBox.Show($"{m.MenuAdı} Menüye Başarıyla Eklendi");

            txtMenüAdı.Text = string.Empty;
            numericUpDown1.Value = default;

        }
    }
}
