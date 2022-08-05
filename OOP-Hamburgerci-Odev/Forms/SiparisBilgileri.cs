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
    public partial class siparisBilgileri : Form
    {
        public List<Siparis> siparisler;
        public List<ExtraMalzemeler> malzemeler;

        public siparisBilgileri()
        {
            InitializeComponent();
        }

        private void siparisBilgileri_Load(object sender, EventArgs e)
        {

            foreach (var item in siparisler)
            {
                lbxTumSiparisler.Items.Add(item.menu.MenuAdı);
            }



            lblCiro.Text = siparisler.Sum(x => x.menu.Fiyati).ToString();
            lblToplamSiparis.Text = siparisler.Count().ToString();
            lblSatilanUrun.Text = siparisler.Sum(x => x.adet).ToString();
            lblExtraMalzeme.Text = ExtraMalzemeler.ToplamExtralar.ToString();
        }
    }
}
