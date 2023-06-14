using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace TurkceSozluk
{
    public partial class Display : UserControl
    {
        public Display()
        {
            InitializeComponent();
        }

        Color baslikColor = Color.FromArgb(255, 64, 64);
        private Color _gradient1 = Color.FromArgb(225,225,225);
        private Color _gradient2 = Color.FromArgb(150,150,150);

        #region Ozellik

        private string _kelime;
        private string _ek;
        private string _cogul;
        private string _ozel;
        private string _dil;
        private string _word_id;

        [Category("Basliklar")]
        public string Kelime
        {
            get => _kelime;
            set
            {
                _kelime = value;
                if (string.IsNullOrEmpty(_kelime))
                {
                    baslik_LBL.ForeColor = ControlPaint.Light(_gradient2, 0.5f);
                    baslik_LBL.Text = @"Kelime Seçilmedi";
                }
                else
                {
                    baslik_LBL.ForeColor = baslikColor;
                    baslik_LBL.Text = value;
                }
            }
        }

        [Category("Basliklar")]
        public string Ek
        {
            get => _ek;
            set
            {
                _ek = value;
                SonEk_LBL.Text = value;
            }
        }

        [Category("Basliklar")]
        public string Cogul
        {
            get => _cogul;
            set
            {
                _cogul = value;
                Cogul_LBL.Text = value;
            }
        }

        [Category("Basliklar")]
        public string Ozel
        {
            get => _ozel;
            set
            {
                _ozel = value;
                Ozel_LBL.Text = value;
            }
        }

        [Category("Basliklar")]
        public string Dil
        {
            get => _dil;
            set
            {
                _dil = value;
                Dil_LBL.Text = value;
            }
        }

        [Category("Basliklar")]
        public string Word_id
        {
            get => _word_id;
            set
            {
                _word_id = value;
                Kelime_id.Text = value;
            }
        }

        #endregion

        private void Display_Paint(object sender, PaintEventArgs e)
        {
            Graphics grp = e.Graphics;
            grp.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rct = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush brs = new LinearGradientBrush(new Rectangle(0, rct.Height, rct.Width, rct.Height),
                Parent.BackColor, Color.Black, 90f, true);

            grp.FillRectangle(brs, rct);
            rct = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            brs = new LinearGradientBrush(rct, _gradient1, _gradient2, LinearGradientMode.ForwardDiagonal);
            grp.FillRectangle(brs, rct);

            grp.DrawLine(Pens.DimGray, Dil_LBL.Left, Dil_LBL.Top, this.Width - Dil_LBL.Left, Dil_LBL.Location.Y);

            grp.Dispose();
            brs.Dispose();
        }

        private void LBL_TextChanged(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.Height = !string.IsNullOrEmpty(lbl.Text) ? 18 : 4;
            }
        }
    }
}
