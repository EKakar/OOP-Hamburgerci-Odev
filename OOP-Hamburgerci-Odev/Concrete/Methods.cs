using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci_Odev.Concrete
{
    public static class Methods
    {
        //HATA VERİYOR
        public static void Clear(Form f)
        {
            foreach (var item in f.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedItem = default;
                }
            }
        }
    }
}
