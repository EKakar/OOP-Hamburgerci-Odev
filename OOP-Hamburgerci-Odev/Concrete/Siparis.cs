using OOP_Hamburgerci_Odev.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci_Odev.Concrete
{
    public class Siparis
    {

        public Siparis()
        {
            malzemelers = new List<ExtraMalzemeler>();
        }
        public static double Fiyat { get; set; }

        public Menu menu { get; set; }

        public static List<ExtraMalzemeler> malzemelers { get; set; }

        public int adet { get; set; }



        public static double Tutar(Menu m, Boyut boyut)
        {
            if (boyut == Boyut.Küçük)
            {
                Siparis.Fiyat = m.Fiyati;
            }
            else if (boyut == Boyut.Orta)
            {
                Siparis.Fiyat = m.Fiyati * 1.1;
            }
            else if (boyut == Boyut.Büyük)
            {
                Siparis.Fiyat = m.Fiyati * 1.2;
            }

            return Siparis.Fiyat;
        }

        public override string ToString()
        {
            return ($"{adet} adet {menu.boyut} boy {menu.MenuAdı} menü");

        }
    }
}
