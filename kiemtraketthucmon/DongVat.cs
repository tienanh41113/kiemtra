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
        private string Maulong;
        public string Color
        {
            get
            {
                return Maulong;
            }
            set
            {
                Maulong = value;
            }
        }
        public virtual void OK()
        {
            if (sound.Equals("Gâu Gâu") && (Color.Equals("Vàng")))
                MessageBox.Show("Chó kêu: " + this.sound + "  Tôi là chó lông màu: " + this.Color);
            else if (sound.Equals("Meow Meow") && (Color.Equals("Đen")))
                MessageBox.Show("Mèo kêu: " + this.sound + "  Tôi là mèo lông màu: " + this.Color);
        }
    }
}
