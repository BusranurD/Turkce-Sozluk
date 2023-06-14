using System;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkceSozluk
{
    public partial class SozlukMainForm : Form
    {
        public SozlukMainForm()
        {
            InitializeComponent();
        }

        private SQLiteConnection sozlukDbBaglan = new SQLiteConnection(@"Data Source=SozlukAA.db;Version=3;");
        private SQLiteCommand SQLKomut;
       
        private DataTable SozlukDBTablo;

        private Color maddeColor = Color.Black;
        private Color kelimetipColor = Color.Red;
        private Color kullanimtipColor = Color.Green;
        private Color baglamColor = Color.Blue;
        public Color anlamColor = Color.FromArgb(0x1B262C);
        private Color ornekcumleColor = Color.FromArgb(0x4C0027);    //Color.FromArgb(0X200F21);

        private Font maddeFont = new Font("Segoe UI", 10, FontStyle.Bold);
        private Font kelimetipFont = new Font("Candara", 10, FontStyle.Italic);
        private Font kullanimtipFont = new Font("Candara", 10, FontStyle.Italic);
        private Font baglamFont = new Font("Candara", 10, FontStyle.Italic);
        private Font anlamFont = new Font("Trebuchet MS", 11, FontStyle.Bold);
        private Font ornekcumleFont = new Font("Trebuchet MS", 10, FontStyle.Italic);
        private Font bosSatirFont = new Font("Segoe UI", 5, FontStyle.Regular);

        private class Kelime
        {
            public string _id { set; get; } = string.Empty;
            public string _kelime { set; get; } = string.Empty;
            public string _ek { set; get; } = string.Empty;
            public string _cogul { set; get; } = string.Empty;
            public string _ozel { set; get; } = string.Empty;
            public string _dil { set; get; } = string.Empty;
            public string _multno { set; get; } = string.Empty;
            public string _ara { set; get; } = string.Empty;

        }

        private readonly Kelime _secilenKelime = new Kelime();

        private readonly WebBrowser _tdkBrowser = new WebBrowser();

        private string url = "https://sozluk.gov.tr/"; // Türk Dil Kurumu web sayfa adresi

        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int description, int reservedValue);
        public static bool NetBaglantiKontrol()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KelimelerListesi();
            Application.DoEvents();
            Aranan.Focus();
        }

        private void KelimelerListesi()
        {
            var sorguTxt = @"Select WORD_ID, MULT_NO, HEAD_MULT, SUFFIX, PLURAL, SPECIAL, LANGUAGE1 From WORDMULT WHERE MULT_NO=0 AND HEAD_MULT >= 'A' ORDER BY HEAD_MULT";

            if (sozlukDbBaglan.State == ConnectionState.Closed)
            {
                sozlukDbBaglan.Open();
            }
            SQLKomut = new SQLiteCommand(sorguTxt, sozlukDbBaglan);
            SozlukDBTablo = new DataTable();
            SozlukDBTablo.Load(SQLKomut.ExecuteReader());

            kelime.DataSource = SozlukDBTablo;
            kelimesayac.Text = $@"Bulunan Kelime {SozlukDBTablo.Rows.Count}";

            for (var i = 0; i < kelime.Columns.Count; i++)
            {
                kelime.Columns[i].Visible = false;
            }

            kelime.Columns["HEAD_MULT"].Visible = true;
            kelime.Columns["HEAD_MULT"].Width = 200;

            kelime.Sort(kelime.Columns["HEAD_MULT"], ListSortDirection.Ascending);
            Sira_ASC.Checked = true;

            sozlukDbBaglan.Close();
            SQLKomut.Dispose();
        }

        // Harici font yükleme kodu
        //private System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();

        //private int scrollBarWidth = System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;

        private void AnlamlariYazdir()
        {
            var sorguTxt = "Select * From SENSES Where MULT_NO=" + _secilenKelime._multno + " AND WORD_ID=" + _secilenKelime._id;
            if (sozlukDbBaglan.State == ConnectionState.Closed) sozlukDbBaglan.Open();
            SQLKomut = new SQLiteCommand(sorguTxt, sozlukDbBaglan);
            SQLiteDataReader dbKelimeOku = SQLKomut.ExecuteReader();

            Anlamlar.Clear();

            if (dbKelimeOku.HasRows)
            {
                var kelimeTip = string.Empty;
                var kullanimTip = string.Empty;
                var baglam = string.Empty;
                var anlam = string.Empty;
                var ornekcumle = string.Empty;
                var madde = 1;

                KelimeOz.Kelime = _secilenKelime._kelime;
                KelimeOz.Ek = _secilenKelime._ek;
                KelimeOz.Cogul = _secilenKelime._cogul;
                KelimeOz.Ozel = _secilenKelime._ozel;
                KelimeOz.Dil = _secilenKelime._dil;

                while (dbKelimeOku.Read())
                {
                    if (!string.IsNullOrEmpty(dbKelimeOku["WORD_TYPE1"].ToString()))
                    {
                        kelimeTip = dbKelimeOku["WORD_TYPE1"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dbKelimeOku["WORD_TYPE2"].ToString()))
                    {
                        kelimeTip += ", " + dbKelimeOku["WORD_TYPE2"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dbKelimeOku["WORD_TYPE3"].ToString()))
                    {
                        kelimeTip += ", " + dbKelimeOku["WORD_TYPE3"].ToString() + "\r\n";
                    }
                    if (!string.IsNullOrEmpty(dbKelimeOku["USAGE_TYPE1"].ToString()))
                    {
                        kullanimTip = dbKelimeOku["USAGE_TYPE1"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dbKelimeOku["USAGE_TYPE2"].ToString()))
                    {
                        kullanimTip += ", " + dbKelimeOku["USAGE_TYPE2"].ToString() + ", \r\n";
                    }
                    if (!string.IsNullOrEmpty(dbKelimeOku["CONTEXT1"].ToString()))
                    {
                        baglam = dbKelimeOku["CONTEXT1"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dbKelimeOku["CONTEXT2"].ToString()))
                    {
                        baglam += ", " + dbKelimeOku["CONTEXT2"].ToString() + "\r\n";
                    }
                    if (!string.IsNullOrEmpty(dbKelimeOku["MEANING"].ToString()))
                    {
                        anlam = dbKelimeOku["MEANING"].ToString() + ", \r\n";
                    }
                    if (!string.IsNullOrEmpty(dbKelimeOku["CÜMLE"].ToString()))
                    {
                        ornekcumle = dbKelimeOku["CÜMLE"].ToString().Trim(); //.ToString().Trim('\t', '\r', '\n', (char)10, (char)13, (char)32);

                        var textcumle = true;
                        byte cumlesay = 1;

                        while (textcumle)
                        {
                            textcumle = ornekcumle.Contains($"Cümle {cumlesay}:");
                            if (textcumle)
                            {
                                ornekcumle = ornekcumle.Replace($"Cümle {cumlesay}:", "...");
                                cumlesay++;
                            }
                        }
                        ornekcumle += Environment.NewLine;
                    }

                    Anlamlar.SelectionColor = maddeColor;
                    Anlamlar.SelectionFont = maddeFont;
                    Anlamlar.AppendText(" " + madde + ".  ");

                    if (!string.IsNullOrEmpty(kelimeTip))
                    {
                        Anlamlar.SelectionFont = kelimetipFont;
                        Anlamlar.SelectionColor = kelimetipColor;
                        Anlamlar.AppendText($"({kelimeTip}) ");
                    }

                    if (!string.IsNullOrEmpty(kullanimTip))
                    {
                        Anlamlar.SelectionFont = kullanimtipFont;
                        Anlamlar.SelectionColor = kullanimtipColor;
                        Anlamlar.AppendText($"({kullanimTip}) ");
                    }

                    if (!string.IsNullOrEmpty(baglam))
                    {
                        if (baglam.EndsWith(",")) baglam.Remove(baglam.Length - 1, 1);
                        Anlamlar.SelectionFont = baglamFont;
                        Anlamlar.SelectionColor = baglamColor;
                        Anlamlar.AppendText($"({baglam}) ");
                    }

                    Anlamlar.SelectionColor = anlamColor;
                    Anlamlar.SelectionFont = anlamFont;
                    Anlamlar.AppendText(anlam);

                    Anlamlar.SelectionFont = bosSatirFont;
                    Anlamlar.AppendText(" " + Environment.NewLine);

                    if (!string.IsNullOrEmpty(ornekcumle))
                    {
                        Anlamlar.SelectionColor = ornekcumleColor;
                        Anlamlar.SelectionFont = ornekcumleFont;
                        Anlamlar.AppendText($"\t{ornekcumle}");

                        Anlamlar.SelectionFont = bosSatirFont;
                        Anlamlar.AppendText(" " + Environment.NewLine);
                    }

                    kelimeTip = string.Empty;
                    kullanimTip = string.Empty;
                    anlam = string.Empty;
                    ornekcumle = string.Empty;
                    madde++;
                }
            }

            SQLKomut.Dispose();
            sozlukDbBaglan.Close();
        }

        private void Kelime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _secilenKelime._id = string.Empty;
            _secilenKelime._kelime = string.Empty;
            _secilenKelime._ek = string.Empty;
            _secilenKelime._cogul = string.Empty;
            _secilenKelime._ozel = string.Empty;
            _secilenKelime._dil = string.Empty;
            _secilenKelime._multno = string.Empty;

            _secilenKelime._id = KelimeOz.Word_id = kelime.SelectedRows[0].Cells["WORD_ID"].Value.ToString();
            _secilenKelime._kelime = KelimeOz.Kelime = kelime.SelectedRows[0].Cells["HEAD_MULT"].Value.ToString();
            _secilenKelime._ek = KelimeOz.Ek = kelime.SelectedRows[0].Cells["SUFFIX"].Value.ToString();
            _secilenKelime._cogul = KelimeOz.Cogul = kelime.SelectedRows[0].Cells["PLURAL"].Value.ToString();
            _secilenKelime._ozel = KelimeOz.Ozel = kelime.SelectedRows[0].Cells["SPECIAL"].Value.ToString();
            _secilenKelime._dil = KelimeOz.Dil = kelime.SelectedRows[0].Cells["LANGUAGE1"].Value.ToString();
            _secilenKelime._multno = kelime.SelectedRows[0].Cells["MULT_NO"].Value.ToString();

            BirlesikKelimeListe();

            AnlamlariYazdir();
        }

        private void BirlesikKelimeListe()
        {
            var sorguTxt = "Select * From WORDMULT where MULT_NO != 0 AND WORD_ID=" + _secilenKelime._id;

            if (sozlukDbBaglan.State == ConnectionState.Open) sozlukDbBaglan.Close();
            sozlukDbBaglan.Open();
            SQLKomut = new SQLiteCommand(sorguTxt, sozlukDbBaglan);
            SozlukDBTablo = new DataTable();
            SozlukDBTablo.Load(SQLKomut.ExecuteReader());

            birlesikKelimeListe.DataSource = SozlukDBTablo;

            for (var i = 0; i < birlesikKelimeListe.Columns.Count; i++)
            {
                birlesikKelimeListe.Columns[i].Visible = false;
            }

            birlesikKelimeListe.Columns["HEAD_MULT"].Visible = true;
            altkelime.Text = $@"Bulunan Kelime {birlesikKelimeListe.RowCount}";

            sozlukDbBaglan.Close();
            SozlukDBTablo.Dispose();
            SQLKomut.Dispose();
        }

        private void Btn_ARA_Click(object sender, EventArgs e)
        {
            SolPanel.Enabled = false;
            SagPanel.Enabled = false;
            btn_ARA.ContextMenuStrip.Show(btn_ARA, new Point(btn_ARA.DisplayRectangle.X + 1, btn_ARA.DisplayRectangle.Top + btn_ARA.Height));
            Application.DoEvents();
            SolPanel.Enabled = true;
            SagPanel.Enabled = true;
            menu4.Enabled = NetBaglantiKontrol();
        }

        private void YanListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _secilenKelime._multno = birlesikKelimeListe.SelectedRows[0].Cells["MULT_NO"].Value.ToString();
            _secilenKelime._kelime = birlesikKelimeListe.SelectedRows[0].Cells["HEAD_MULT"].Value.ToString();
            AnlamlariYazdir();
        }

        private void Sira_ASC_Click(object sender, EventArgs e)
        {
            kelime.Sort(kelime.Columns["HEAD_MULT"], ListSortDirection.Ascending);
        }

        private void Sira_DESC_CheckedChanged(object sender, EventArgs e)
        {
            kelime.Sort(kelime.Columns["HEAD_MULT"], ListSortDirection.Descending);
        }

        private void Aranan_TextChanged(object sender, EventArgs e)
        {
            if (Aranan.Text != string.Empty)
            {
                btn_ARA.Enabled = true;

                menu2.Text = $@"... ile başlayan kelimeleri Listele"; menu2.Tag = "2";
                menu3.Text = $@"İçerisinde ... geçen kelimeleri Listele"; menu3.Tag = "3";
                menu1.Text = $@"Yalnızca ... kelimesini Listele"; menu1.Tag = "1";

                Anlamlar.Clear();

                var arananKelime = $"\"{Aranan.Text}\"";

                birlesikKelimeListe.DataSource = null;
                menu1.Text = menu1.Text.Replace("...", arananKelime);
                menu2.Text = menu2.Text.Replace("...", arananKelime);
                menu3.Text = menu3.Text.Replace("...", arananKelime);
            }
            else
            {
                btn_ARA.Enabled = false;
                KelimelerListesi();
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Aranan.Text += (sender as Button)?.Text;
            Aranan.SelectionStart = Aranan.Text.Length;
            Aranan.Select();
        }

        private void Siralama_Secim(object sender, EventArgs e)
        {
            var mtag = (sender as ToolStripMenuItem)?.Tag.ToString();
            MenuSecim(mtag);
            SolPanel.Enabled = true;
            SagPanel.Enabled = true;
        }

        private void MenuSecim(string secim)
        {
            bool menubtnsecim = false;
            switch (secim)
            {
                case "2":
                    menubtnsecim = true;
                    _secilenKelime._ara = $"LIKE '{Aranan.Text}%'";
                    break;
                case "3":
                    menubtnsecim = true;
                    _secilenKelime._ara = $"LIKE ('%{Aranan.Text}%')";
                    break;
                case "1":
                    menubtnsecim = true;
                    _secilenKelime._ara = $" = '{Aranan.Text}'";
                    break;
            }

            if (menubtnsecim)
            {
                var sorgulaTxt = $"Select WORD_ID, MULT_NO, HEAD_MULT, SUFFIX, PLURAL, SPECIAL, LANGUAGE1 From WORDMULT WhERE HEAD_MULT {_secilenKelime._ara} ORDER BY HEAD_MULT;";

                if (sozlukDbBaglan.State == ConnectionState.Open) sozlukDbBaglan.Close();

                sozlukDbBaglan.Open();
                SQLKomut = new SQLiteCommand(sorgulaTxt, sozlukDbBaglan);
                SozlukDBTablo = new DataTable();
                SozlukDBTablo.Load(SQLKomut.ExecuteReader());

                if (SozlukDBTablo.Rows.Count > 0)
                {

                    kelimesayac.Text = $@"Bulunan Kelime {SozlukDBTablo.Rows.Count}";

                    kelime.DataSource = SozlukDBTablo;
                }
                else
                {
                    KelimeBulunamadi();
                }

                sozlukDbBaglan.Close();
                SQLKomut.Dispose();
                SozlukDBTablo.Dispose();
            }
        }

        private void KelimeBulunamadi()
        {
            var msg = $" {Aranan.Text} Kelimesi Sözlük içinde bulunmamaktadır.\r\n\r\n TDK İnternet Sayfasında Arayalım mı ?";
            var onay = MessageBox.Show(msg, @"Kayıt Bulunamadı", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                if (NetBaglantiKontrol())
                {
                    menu4.PerformClick();
                }
                else
                {
                    MessageBox.Show(@"İnternet Bağlantınız Mevcut Değil. Bağlantınızı Kontrol Ediniz..!",
                        @"Hata", MessageBoxButtons.OK);
                }
            }
        }

        private void Kelime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0) e.CellStyle.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void Sayac_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (sender as Label);
            if (!string.IsNullOrEmpty(lbl.Text))
            {
                StringFormat sf = new StringFormat(StringFormatFlags.DisplayFormatControl);
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;
                Graphics grp = e.Graphics;
                grp.SmoothingMode = SmoothingMode.AntiAlias;
                grp.Clear(lbl.BackColor);
                grp.TranslateTransform(lbl.Width / 2, lbl.Height);
                grp.RotateTransform(-90f);
                grp.DrawString(lbl.Text, lbl.Font, Brushes.DarkGray, 0, 0, sf);
                grp.ResetTransform();
                sf.Dispose();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //pfc.Dispose();
            _tdkBrowser.Dispose();
            KelimeOz.Dispose();
            maddeFont.Dispose();
            kelimetipFont.Dispose();
            kullanimtipFont.Dispose();
            baglamFont.Dispose();
            anlamFont.Dispose();
            ornekcumleFont.Dispose();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private async void tdknet_Click(object sender, EventArgs e)
        {
            KelimeOz.Kelime = Aranan.Text;

            try
            {
                Anlamlar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                Anlamlar.ForeColor = Color.FromArgb(0x303030);
                _tdkBrowser.Navigate(url);
                _tdkBrowser.ScriptErrorsSuppressed = true;
                await TdkSayfaYukle(1);

                _tdkBrowser.Document.GetElementById("tdk-srch-input").SetAttribute("value", Aranan.Text.Trim());
                await TdkSayfaYukle(1);

                _tdkBrowser.Document.GetElementById("tdk-search-btn")?.InvokeMember("click");
                await TdkSayfaYukle(1);

                HtmlElement htmlMaddeler = _tdkBrowser.Document.GetElementById("anlamlar-gts0");

                if (htmlMaddeler != null)
                {
                    Anlamlar.Text = htmlMaddeler.InnerText;
                }
                else
                {
                    MessageBox.Show(@"TDK'da böyle bir kelime yer almamaktadır.", @"Kelime Yok!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"TDK Sayfasına bağlanamıyor. Net Bağlantınızı kontrold Edin..!" + "\r" + ex.Message);
                return;
            }

            Aranan.Text = string.Empty;
        }

        private async Task TdkSayfaYukle(int timeOut) // sayfayı bekletme
        {
            TaskCompletionSource<bool> pageLoaded = null;
            pageLoaded = new TaskCompletionSource<bool>();
            int timeElapsed = 0;
            _tdkBrowser.DocumentCompleted += (s, e) =>
            {
                if (_tdkBrowser.ReadyState != WebBrowserReadyState.Complete) return;
                if (pageLoaded.Task.IsCompleted) return; pageLoaded.SetResult(true);
            };
            while (pageLoaded.Task.Status != TaskStatus.RanToCompletion)
            {
                await Task.Delay(5);
                timeElapsed++;
                if (timeElapsed >= timeOut * 50) pageLoaded.TrySetResult(true);
            }
        }

        private void Aranan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
               
            }
        }

        public Point ClickPoint = Point.Empty;

        private void TitleDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.SizeAll;
                ClickPoint = new Point(e.X, e.Y);
            }
        }

        private void TitleMove(object sender, MouseEventArgs e)
        {
            if (ClickPoint != Point.Empty)
                Location = new Point(Left + e.X - ClickPoint.X, Top + e.Y - ClickPoint.Y);
        }

        private void TitleUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickPoint = Point.Empty;
                Cursor = Cursors.Default;
            }
        }

        private void TitlePanelDrawing(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(10, 10);
            Point endPoint = new Point(50, 50);
            Rectangle rect = new Rectangle(TitlePanel.Width / 2, 0, TitlePanel.Width, TitlePanel.Height);
            Graphics g = e.Graphics;


            LinearGradientBrush lgb =
                new LinearGradientBrush(startPoint, endPoint, Color.FromArgb(125, 125, 125), Color.FromArgb(120, 120, 120));
            g.FillRectangle(lgb, rect);

            var pens = new Pen(Color.FromArgb(90, 90, 90))
            {
                Alignment = PenAlignment.Center,
                Width = 1,
            };
            g.DrawLine(pens, new Point(0, TitlePanel.Height - 1), new Point(TitlePanel.Width, TitlePanel.Height - 1));

            pens.Dispose();
            g.Dispose();
            lgb.Dispose();
        }

        private void SozlukMainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(Pens.DarkOrange, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
