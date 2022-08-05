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
    public partial class siparisOlustur : Form
    {

        Siparis siparis;
        CheckBox malzeme;
        public List<Menu> menuler;
        public List<Siparis> siparisler;
        public List<ExtraMalzemeler> malzemeler;


        public siparisOlustur()
        {
            InitializeComponent();
        }

        private void siparisOlustur_Load(object sender, EventArgs e)
        {
            rdbKucuk.Checked = true;

            cmbMenuBox.Text = menuler[0].MenuAdı;
            cmbMenuBox.DataSource = menuler;
            cmbMenuBox.DisplayMember = "MenuAdı";


            foreach (var item in malzemeler)
            {
                malzeme = new CheckBox();
                flpExrtaMalzemeler.Controls.Add(malzeme);
                malzeme.Text = item.Adı;
            }


        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {


            siparis = new Siparis();
            siparis.menu = (Menu)cmbMenuBox.SelectedItem;

            if (nudAdet.Value == 0)
            {
                MessageBox.Show("Hamburger Adeti '0' Olamaz!!");
            }
            else
            {
                siparis.adet = (int)nudAdet.Value;
            }


            if (rdbBuyuk.Checked)
            {
                Siparis.Fiyat = siparis.adet * (Siparis.Tutar((Menu)cmbMenuBox.SelectedItem, Boyut.Büyük));
                siparis.menu.boyut = Boyut.Büyük;
            }
            else if (rdbOrta.Checked)
            {
                Siparis.Fiyat = siparis.adet * (Siparis.Tutar((Menu)cmbMenuBox.SelectedItem, Boyut.Orta));
                siparis.menu.boyut = Boyut.Orta;
            }
            else
            {
                Siparis.Fiyat = siparis.adet * (Siparis.Tutar((Menu)cmbMenuBox.SelectedItem, Boyut.Küçük));
                siparis.menu.boyut = Boyut.Küçük;
            }


            foreach (CheckBox item in flpExrtaMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    foreach (var item1 in malzemeler)
                    {
                        if (item.Text == item1.Adı)
                        {
                            Siparis.malzemelers.Add(item1);
                            Siparis.Fiyat += (siparis.adet * item1.MalzemeFiyati);
                            ExtraMalzemeler.ToplamExtralar += (siparis.adet * item1.MalzemeFiyati);
                            //EXTRA MALZEMELERİN HEPSİNİ YAZDIR
                        }
                    }
                }
            }

            siparisler.Add(siparis);

            lblToplamTutar.Text = Siparis.Fiyat.ToString();
            lbxSiparisler.Items.Add(siparis.ToString());
            lbxSiparisler.Items.Add("Extra malzeme ücreti : " + ((int)nudAdet.Value * Siparis.malzemelers.Sum(x => x.MalzemeFiyati)));



            MessageBox.Show("Siparişiniz başarıyla oluşturuldu");
        }


        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Siparişiniz başarıyla tamamlandı.");

            cmbMenuBox.Controls.Clear();
            flpExrtaMalzemeler.Enabled = true;
            nudAdet.Value = 1;
            lblToplamTutar.Text = "0";
            lbxSiparisler.Items.Clear();
        }
    }
}

