namespace TurkceSozluk
{
    partial class SozlukMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SozlukMainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Aranan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ARA = new System.Windows.Forms.Button();
            this.aramenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Anlamlar = new System.Windows.Forms.RichTextBox();
            this.kelime = new System.Windows.Forms.DataGridView();
            this.birlesikKelimeListe = new System.Windows.Forms.DataGridView();
            this.Sira_ASC = new System.Windows.Forms.RadioButton();
            this.Sira_DESC = new System.Windows.Forms.RadioButton();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.altkelime = new System.Windows.Forms.Label();
            this.kelimesayac = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SagPanel = new System.Windows.Forms.Panel();
            this.KelimeOz = new TurkceSozluk.Display();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SolPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aramenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birlesikKelimeListe)).BeginInit();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SagPanel.SuspendLayout();
            this.SolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aranan
            // 
            this.Aranan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Aranan.Location = new System.Drawing.Point(10, 26);
            this.Aranan.Margin = new System.Windows.Forms.Padding(4);
            this.Aranan.Name = "Aranan";
            this.Aranan.Size = new System.Drawing.Size(241, 32);
            this.Aranan.TabIndex = 0;
            this.Aranan.TextChanged += new System.EventHandler(this.Aranan_TextChanged);
            this.Aranan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Aranan_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelime";
            // 
            // btn_ARA
            // 
            this.btn_ARA.ContextMenuStrip = this.aramenu;
            this.btn_ARA.Enabled = false;
            this.btn_ARA.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_ARA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ARA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_ARA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ARA.Image = ((System.Drawing.Image)(resources.GetObject("btn_ARA.Image")));
            this.btn_ARA.Location = new System.Drawing.Point(257, 15);
            this.btn_ARA.Name = "btn_ARA";
            this.btn_ARA.Size = new System.Drawing.Size(38, 38);
            this.btn_ARA.TabIndex = 2;
            this.btn_ARA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ARA.UseVisualStyleBackColor = true;
            this.btn_ARA.Click += new System.EventHandler(this.Btn_ARA_Click);
            // 
            // aramenu
            // 
            this.aramenu.AllowMerge = false;
            this.aramenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.aramenu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.aramenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.aramenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1,
            this.menu2,
            this.menu3,
            this.toolStripSeparator1,
            this.menu4});
            this.aramenu.Name = "secim1";
            this.aramenu.ShowItemToolTips = false;
            this.aramenu.Size = new System.Drawing.Size(392, 130);
            this.aramenu.Tag = "";
            this.aramenu.Text = "Seçimler";
            this.aramenu.Click += new System.EventHandler(this.Siralama_Secim);
            // 
            // menu1
            // 
            this.menu1.Image = ((System.Drawing.Image)(resources.GetObject("menu1.Image")));
            this.menu1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu1.MergeIndex = 0;
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(391, 30);
            this.menu1.Tag = "1";
            this.menu1.Text = "Yalnızca ... kelimesini Listele";
            this.menu1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.menu1.Click += new System.EventHandler(this.Siralama_Secim);
            // 
            // menu2
            // 
            this.menu2.Image = ((System.Drawing.Image)(resources.GetObject("menu2.Image")));
            this.menu2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu2.MergeIndex = 1;
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(391, 30);
            this.menu2.Tag = "2";
            this.menu2.Text = "... ile başlayan kelimeleri Listele";
            this.menu2.Click += new System.EventHandler(this.Siralama_Secim);
            // 
            // menu3
            // 
            this.menu3.Image = ((System.Drawing.Image)(resources.GetObject("menu3.Image")));
            this.menu3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu3.MergeIndex = 2;
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(391, 30);
            this.menu3.Tag = "3";
            this.menu3.Text = "İçerisinde ... geçen kelimeleri Listele";
            this.menu3.Click += new System.EventHandler(this.Siralama_Secim);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(388, 6);
            // 
            // menu4
            // 
            this.menu4.MergeIndex = 3;
            this.menu4.Name = "menu4";
            this.menu4.Size = new System.Drawing.Size(391, 30);
            this.menu4.Text = "TDK Web Sayfasında ara";
            this.menu4.Click += new System.EventHandler(this.tdknet_Click);
            // 
            // Anlamlar
            // 
            this.Anlamlar.BackColor = System.Drawing.Color.White;
            this.Anlamlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Anlamlar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Anlamlar.DetectUrls = false;
            this.Anlamlar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Anlamlar.Location = new System.Drawing.Point(10, 101);
            this.Anlamlar.MaxLength = 5000;
            this.Anlamlar.Name = "Anlamlar";
            this.Anlamlar.ReadOnly = true;
            this.Anlamlar.ShortcutsEnabled = false;
            this.Anlamlar.Size = new System.Drawing.Size(482, 415);
            this.Anlamlar.TabIndex = 4;
            this.Anlamlar.Text = "";
            this.Anlamlar.ZoomFactor = 2F;
            // 
            // kelime
            // 
            this.kelime.AllowUserToAddRows = false;
            this.kelime.AllowUserToDeleteRows = false;
            this.kelime.AllowUserToResizeColumns = false;
            this.kelime.AllowUserToResizeRows = false;
            this.kelime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kelime.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.kelime.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.kelime.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.kelime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kelime.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kelime.DefaultCellStyle = dataGridViewCellStyle3;
            this.kelime.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kelime.Location = new System.Drawing.Point(10, 115);
            this.kelime.MultiSelect = false;
            this.kelime.Name = "kelime";
            this.kelime.ReadOnly = true;
            this.kelime.RowHeadersVisible = false;
            this.kelime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kelime.Size = new System.Drawing.Size(241, 246);
            this.kelime.TabIndex = 5;
            this.kelime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Kelime_CellClick);
            this.kelime.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Kelime_CellFormatting);
            // 
            // birlesikKelimeListe
            // 
            this.birlesikKelimeListe.AllowUserToAddRows = false;
            this.birlesikKelimeListe.AllowUserToDeleteRows = false;
            this.birlesikKelimeListe.AllowUserToResizeColumns = false;
            this.birlesikKelimeListe.AllowUserToResizeRows = false;
            this.birlesikKelimeListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.birlesikKelimeListe.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.birlesikKelimeListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.birlesikKelimeListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.birlesikKelimeListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.birlesikKelimeListe.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.birlesikKelimeListe.DefaultCellStyle = dataGridViewCellStyle4;
            this.birlesikKelimeListe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.birlesikKelimeListe.Location = new System.Drawing.Point(9, 390);
            this.birlesikKelimeListe.MultiSelect = false;
            this.birlesikKelimeListe.Name = "birlesikKelimeListe";
            this.birlesikKelimeListe.ReadOnly = true;
            this.birlesikKelimeListe.RowHeadersVisible = false;
            this.birlesikKelimeListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.birlesikKelimeListe.Size = new System.Drawing.Size(241, 119);
            this.birlesikKelimeListe.TabIndex = 5;
            this.birlesikKelimeListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YanListe_CellClick);
            this.birlesikKelimeListe.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Kelime_CellFormatting);
            // 
            // Sira_ASC
            // 
            this.Sira_ASC.Appearance = System.Windows.Forms.Appearance.Button;
            this.Sira_ASC.Image = ((System.Drawing.Image)(resources.GetObject("Sira_ASC.Image")));
            this.Sira_ASC.Location = new System.Drawing.Point(257, 115);
            this.Sira_ASC.Name = "Sira_ASC";
            this.Sira_ASC.Size = new System.Drawing.Size(38, 38);
            this.Sira_ASC.TabIndex = 10;
            this.Sira_ASC.TabStop = true;
            this.Sira_ASC.UseVisualStyleBackColor = true;
            this.Sira_ASC.Click += new System.EventHandler(this.Sira_ASC_Click);
            // 
            // Sira_DESC
            // 
            this.Sira_DESC.Appearance = System.Windows.Forms.Appearance.Button;
            this.Sira_DESC.Image = ((System.Drawing.Image)(resources.GetObject("Sira_DESC.Image")));
            this.Sira_DESC.Location = new System.Drawing.Point(257, 159);
            this.Sira_DESC.Name = "Sira_DESC";
            this.Sira_DESC.Size = new System.Drawing.Size(38, 38);
            this.Sira_DESC.TabIndex = 10;
            this.Sira_DESC.TabStop = true;
            this.Sira_DESC.UseVisualStyleBackColor = true;
            this.Sira_DESC.CheckedChanged += new System.EventHandler(this.Sira_DESC_CheckedChanged);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b1.Location = new System.Drawing.Point(9, 59);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(22, 23);
            this.b1.TabIndex = 11;
            this.b1.Text = "â";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.B1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b2.Location = new System.Drawing.Point(32, 59);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(22, 23);
            this.b2.TabIndex = 11;
            this.b2.Text = "î";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.B1_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b3.Location = new System.Drawing.Point(55, 59);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(22, 23);
            this.b3.TabIndex = 11;
            this.b3.Text = "û";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.B1_Click);
            // 
            // altkelime
            // 
            this.altkelime.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altkelime.Location = new System.Drawing.Point(259, 446);
            this.altkelime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.altkelime.Name = "altkelime";
            this.altkelime.Size = new System.Drawing.Size(15, 142);
            this.altkelime.TabIndex = 1;
            this.altkelime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.altkelime.Paint += new System.Windows.Forms.PaintEventHandler(this.Sayac_Paint);
            // 
            // kelimesayac
            // 
            this.kelimesayac.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelimesayac.Location = new System.Drawing.Point(260, 302);
            this.kelimesayac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kelimesayac.Name = "kelimesayac";
            this.kelimesayac.Size = new System.Drawing.Size(14, 138);
            this.kelimesayac.TabIndex = 1;
            this.kelimesayac.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kelimesayac.Paint += new System.Windows.Forms.PaintEventHandler(this.Sayac_Paint);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.TitlePanel.Controls.Add(this.button1);
            this.TitlePanel.Controls.Add(this.CloseBtn);
            this.TitlePanel.Controls.Add(this.Title);
            this.TitlePanel.Controls.Add(this.pictureBox1);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(830, 73);
            this.TitlePanel.TabIndex = 15;
            this.TitlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TitlePanelDrawing);
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMove);
            this.TitlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(761, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(799, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(24, 24);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Title.Location = new System.Drawing.Point(89, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(232, 38);
            this.Title.TabIndex = 1;
            this.Title.Text = "TÜRKÇE SÖZLÜK";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleUp);
            // 
            // SagPanel
            // 
            this.SagPanel.BackColor = System.Drawing.Color.White;
            this.SagPanel.Controls.Add(this.KelimeOz);
            this.SagPanel.Controls.Add(this.Anlamlar);
            this.SagPanel.Location = new System.Drawing.Point(323, 74);
            this.SagPanel.Name = "SagPanel";
            this.SagPanel.Padding = new System.Windows.Forms.Padding(2);
            this.SagPanel.Size = new System.Drawing.Size(506, 526);
            this.SagPanel.TabIndex = 16;
            // 
            // KelimeOz
            // 
            this.KelimeOz.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.KelimeOz.BackColor = System.Drawing.Color.LightGray;
            this.KelimeOz.Cogul = null;
            this.KelimeOz.Dil = null;
            this.KelimeOz.Ek = null;
            this.KelimeOz.Kelime = null;
            this.KelimeOz.Location = new System.Drawing.Point(10, 11);
            this.KelimeOz.Margin = new System.Windows.Forms.Padding(5);
            this.KelimeOz.MaximumSize = new System.Drawing.Size(485, 80);
            this.KelimeOz.MinimumSize = new System.Drawing.Size(485, 80);
            this.KelimeOz.Name = "KelimeOz";
            this.KelimeOz.Ozel = null;
            this.KelimeOz.Padding = new System.Windows.Forms.Padding(5);
            this.KelimeOz.Size = new System.Drawing.Size(485, 80);
            this.KelimeOz.TabIndex = 18;
            this.KelimeOz.Word_id = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kelimeler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(13, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birleşik Kelimeler";
            // 
            // SolPanel
            // 
            this.SolPanel.Controls.Add(this.panel1);
            this.SolPanel.Controls.Add(this.Aranan);
            this.SolPanel.Controls.Add(this.label3);
            this.SolPanel.Controls.Add(this.btn_ARA);
            this.SolPanel.Controls.Add(this.label2);
            this.SolPanel.Controls.Add(this.b1);
            this.SolPanel.Controls.Add(this.Sira_ASC);
            this.SolPanel.Controls.Add(this.Sira_DESC);
            this.SolPanel.Controls.Add(this.label1);
            this.SolPanel.Controls.Add(this.birlesikKelimeListe);
            this.SolPanel.Controls.Add(this.b2);
            this.SolPanel.Controls.Add(this.b3);
            this.SolPanel.Controls.Add(this.kelime);
            this.SolPanel.Location = new System.Drawing.Point(3, 76);
            this.SolPanel.Name = "SolPanel";
            this.SolPanel.Size = new System.Drawing.Size(303, 519);
            this.SolPanel.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(10, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 1);
            this.panel1.TabIndex = 16;
            // 
            // SozlukMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(832, 600);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.altkelime);
            this.Controls.Add(this.kelimesayac);
            this.Controls.Add(this.SolPanel);
            this.Controls.Add(this.SagPanel);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(830, 600);
            this.Name = "SozlukMainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TDK Büyük TÜRKÇE SÖZLÜK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SozlukMainForm_Paint);
            this.aramenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kelime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birlesikKelimeListe)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SagPanel.ResumeLayout(false);
            this.SolPanel.ResumeLayout(false);
            this.SolPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Aranan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ARA;
        private System.Windows.Forms.RichTextBox Anlamlar;
        private System.Windows.Forms.DataGridView kelime;
        private System.Windows.Forms.DataGridView birlesikKelimeListe;
        private System.Windows.Forms.RadioButton Sira_ASC;
        private System.Windows.Forms.RadioButton Sira_DESC;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Label kelimesayac;
        private System.Windows.Forms.Label altkelime;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SagPanel;
        private Display KelimeOz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel SolPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip aramenu;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem menu2;
        private System.Windows.Forms.ToolStripMenuItem menu3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu4;
    }
}

