using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kiemtraketthucmon
{
    class DongVat
    {
        private string Keu;
        public void Maulong() { }
        public string sound
        {
            get { return Keu; }
            set { Keu = value; }
        }
        public DongVat(string tKeu)
        {
            this.Keu = tKeu;
        }
         public DongVat() { }
         public virtual void OK()
        {
            if (sound.Equals("Gâu Gâu"))
                MessageBox.Show("Chó kêu: " + this.sound);
            else if (sound.Equals("Meow Meow"))
                MessageBox.Show("Mèo kêu: " + this.sound);
        }
    }
}
