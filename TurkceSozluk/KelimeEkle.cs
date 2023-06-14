using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkceSozluk
{
    public partial class KelimeEkle : UserControl
    {
        public KelimeEkle()
        {
            InitializeComponent();
        }

        private void KelimeEkle_Load(object sender, EventArgs e)
        {
            Random renk = new Random();
            var red = renk.Next(200, 255);
            var green = renk.Next(200,255);
            var blue = renk.Next(200,255);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
