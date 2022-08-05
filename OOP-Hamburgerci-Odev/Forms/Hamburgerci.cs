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
    public partial class Hamburgerci : Form
    {
        public Hamburgerci()
        {
            InitializeComponent();
        }

        List<Menu> menuler;
        List<Siparis> siparisler;
        List<ExtraMalzemeler> malzemeler;


        public void Hamburgerci_Load(object sender, EventArgs e)
        {
            menuler = new List<Menu>()
            {   
                new Menu() { MenuAdı = "King Chicken", Fiyati = 58, boyut = Enums.Boyut.Küçük },
                new Menu() { MenuAdı = "CheeseBurger", Fiyati = 63, boyut = Enums.Boyut.Küçük },
                new Menu() { MenuAdı = "BBQ Soslu Hamburger", Fiyati = 67, boyut = Enums.Boyut.Küçük },
                new Menu() { MenuAdı = "Soyalı/Acılı Chicken", Fiyati = 64, boyut = Enums.Boyut.Küçük },
            };


            malzemeler = new List<ExtraMalzemeler>()
            {
                new ExtraMalzemeler() { Adı = "Ranch Sos", MalzemeFiyati=0.75  },
                new ExtraMalzemeler() { Adı = "BBQ Sos", MalzemeFiyati = 0.75 },
                new ExtraMalzemeler() { Adı = "Bacon", MalzemeFiyati = 5 },
                new ExtraMalzemeler() { Adı = "Kibrit Patates", MalzemeFiyati = 3.5 },
            };

            siparisler = new List<Siparis>();

        }

        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {
            siparisOlustur siparisOlustur = new siparisOlustur();
            siparisOlustur.menuler = this.menuler;
            siparisOlustur.siparisler = this.siparisler;
            siparisOlustur.malzemeler = this.malzemeler;
            siparisOlustur.Show();

        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            siparisBilgileri siparisBilgileri = new siparisBilgileri();
            siparisBilgileri.siparisler = this.siparisler;
            siparisBilgileri.Show();
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            menuEkle menuEkle = new menuEkle();
            menuEkle.menuler = this.menuler;
            menuEkle.Show();
        }

        private void tsmExtraMalzeme_Click(object sender, EventArgs e)
        {
            extraMalzeme extraMalzeme = new extraMalzeme();
            extraMalzeme.malzemeler = this.malzemeler;
            extraMalzeme.Show();
        }

    }
}
