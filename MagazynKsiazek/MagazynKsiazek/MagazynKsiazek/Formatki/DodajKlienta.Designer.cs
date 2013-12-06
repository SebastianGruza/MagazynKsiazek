namespace MagazynKsiazek
{
    partial class DodajKlienta
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykiSprzedażyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImieLabel = new System.Windows.Forms.Label();
            this.ImieTB = new System.Windows.Forms.TextBox();
            this.NazwiskoLabel = new System.Windows.Forms.Label();
            this.UlicaLabel = new System.Windows.Forms.Label();
            this.MiejscowoscLabel = new System.Windows.Forms.Label();
            this.KodPocztLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.NazwiskoTB = new System.Windows.Forms.TextBox();
            this.MiejscowoscTB = new System.Windows.Forms.TextBox();
            this.UlicaTB = new System.Windows.Forms.TextBox();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.DodajBT = new System.Windows.Forms.Button();
            this.KodPocztTB = new System.Windows.Forms.TextBox();
            this.UsunBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WyszukajTB = new System.Windows.Forms.TextBox();
            this.WyszukajLabel = new System.Windows.Forms.Label();
            this.ListaBT = new System.Windows.Forms.Button();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NrLokaluLabel = new System.Windows.Forms.Label();
            this.NrDomuLabel = new System.Windows.Forms.Label();
            this.NrLokaluTB = new System.Windows.Forms.TextBox();
            this.NrDomuTB = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.fakturaToolStripMenuItem,
            this.zamknijToolStripMenuItem,
            this.wylogujToolStripMenuItem,
            this.statystykiSprzedażyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_OknoGlowne);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.dodajToolStripMenuItem.Text = "Baza książek";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_DodajKsiazke);
            // 
            // fakturaToolStripMenuItem
            // 
            this.fakturaToolStripMenuItem.Name = "fakturaToolStripMenuItem";
            this.fakturaToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.fakturaToolStripMenuItem.Text = "Tworzenie faktury";
            this.fakturaToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_TworzenieFaktury);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Zamknij);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Wyloguj);
            // 
            // statystykiSprzedażyToolStripMenuItem
            // 
            this.statystykiSprzedażyToolStripMenuItem.Name = "statystykiSprzedażyToolStripMenuItem";
            this.statystykiSprzedażyToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.statystykiSprzedażyToolStripMenuItem.Text = "Statystyki sprzedaży";
            this.statystykiSprzedażyToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_StatystykiSprzedazy);
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Location = new System.Drawing.Point(20, 67);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(29, 13);
            this.ImieLabel.TabIndex = 1;
            this.ImieLabel.Text = "Imię:";
            // 
            // ImieTB
            // 
            this.ImieTB.Location = new System.Drawing.Point(105, 60);
            this.ImieTB.Name = "ImieTB";
            this.ImieTB.Size = new System.Drawing.Size(157, 20);
            this.ImieTB.TabIndex = 1;
            this.ImieTB.TextChanged += new System.EventHandler(this.ImieTB_TextChanged);
            // 
            // NazwiskoLabel
            // 
            this.NazwiskoLabel.AutoSize = true;
            this.NazwiskoLabel.Location = new System.Drawing.Point(20, 99);
            this.NazwiskoLabel.Name = "NazwiskoLabel";
            this.NazwiskoLabel.Size = new System.Drawing.Size(56, 13);
            this.NazwiskoLabel.TabIndex = 3;
            this.NazwiskoLabel.Text = "Nazwisko:";
            // 
            // UlicaLabel
            // 
            this.UlicaLabel.AutoSize = true;
            this.UlicaLabel.Location = new System.Drawing.Point(294, 67);
            this.UlicaLabel.Name = "UlicaLabel";
            this.UlicaLabel.Size = new System.Drawing.Size(34, 13);
            this.UlicaLabel.TabIndex = 4;
            this.UlicaLabel.Text = "Ulica:";
            // 
            // MiejscowoscLabel
            // 
            this.MiejscowoscLabel.AutoSize = true;
            this.MiejscowoscLabel.Location = new System.Drawing.Point(294, 34);
            this.MiejscowoscLabel.Name = "MiejscowoscLabel";
            this.MiejscowoscLabel.Size = new System.Drawing.Size(71, 13);
            this.MiejscowoscLabel.TabIndex = 5;
            this.MiejscowoscLabel.Text = "Miejscowość:";
            // 
            // KodPocztLabel
            // 
            this.KodPocztLabel.AutoSize = true;
            this.KodPocztLabel.Location = new System.Drawing.Point(294, 130);
            this.KodPocztLabel.Name = "KodPocztLabel";
            this.KodPocztLabel.Size = new System.Drawing.Size(77, 13);
            this.KodPocztLabel.TabIndex = 6;
            this.KodPocztLabel.Text = "Kod pocztowy:";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(20, 130);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(38, 13);
            this.MailLabel.TabIndex = 7;
            this.MailLabel.Text = "E-mail:";
            // 
            // NazwiskoTB
            // 
            this.NazwiskoTB.Location = new System.Drawing.Point(105, 92);
            this.NazwiskoTB.Name = "NazwiskoTB";
            this.NazwiskoTB.Size = new System.Drawing.Size(157, 20);
            this.NazwiskoTB.TabIndex = 2;
            // 
            // MiejscowoscTB
            // 
            this.MiejscowoscTB.Location = new System.Drawing.Point(393, 27);
            this.MiejscowoscTB.Name = "MiejscowoscTB";
            this.MiejscowoscTB.Size = new System.Drawing.Size(166, 20);
            this.MiejscowoscTB.TabIndex = 4;
            // 
            // UlicaTB
            // 
            this.UlicaTB.Location = new System.Drawing.Point(393, 60);
            this.UlicaTB.Name = "UlicaTB";
            this.UlicaTB.Size = new System.Drawing.Size(166, 20);
            this.UlicaTB.TabIndex = 5;
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(105, 123);
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(157, 20);
            this.MailTB.TabIndex = 3;
            // 
            // DodajBT
            // 
            this.DodajBT.Location = new System.Drawing.Point(642, 19);
            this.DodajBT.Name = "DodajBT";
            this.DodajBT.Size = new System.Drawing.Size(75, 23);
            this.DodajBT.TabIndex = 9;
            this.DodajBT.Text = "Dodaj";
            this.DodajBT.UseVisualStyleBackColor = true;
            this.DodajBT.Click += new System.EventHandler(this.DodajBT_Click);
            // 
            // KodPocztTB
            // 
            this.KodPocztTB.Location = new System.Drawing.Point(393, 123);
            this.KodPocztTB.Name = "KodPocztTB";
            this.KodPocztTB.Size = new System.Drawing.Size(52, 20);
            this.KodPocztTB.TabIndex = 8;
            // 
            // UsunBT
            // 
            this.UsunBT.Location = new System.Drawing.Point(642, 134);
            this.UsunBT.Name = "UsunBT";
            this.UsunBT.Size = new System.Drawing.Size(75, 23);
            this.UsunBT.TabIndex = 10;
            this.UsunBT.Text = "Usuń";
            this.UsunBT.UseVisualStyleBackColor = true;
            this.UsunBT.Click += new System.EventHandler(this.UsunBT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(18, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(829, 202);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WyszukajTB);
            this.groupBox1.Controls.Add(this.WyszukajLabel);
            this.groupBox1.Controls.Add(this.ListaBT);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 272);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukiwanie";
            // 
            // WyszukajTB
            // 
            this.WyszukajTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.WyszukajTB.Location = new System.Drawing.Point(219, 20);
            this.WyszukajTB.Name = "WyszukajTB";
            this.WyszukajTB.Size = new System.Drawing.Size(226, 20);
            this.WyszukajTB.TabIndex = 23;
            this.WyszukajTB.TabStop = false;
            this.WyszukajTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WyszukajTB.TextChanged += new System.EventHandler(this.WyszukajTB_TextChanged);
            // 
            // WyszukajLabel
            // 
            this.WyszukajLabel.AutoSize = true;
            this.WyszukajLabel.Location = new System.Drawing.Point(157, 23);
            this.WyszukajLabel.Name = "WyszukajLabel";
            this.WyszukajLabel.Size = new System.Drawing.Size(56, 13);
            this.WyszukajLabel.TabIndex = 21;
            this.WyszukajLabel.Text = "Wyszukaj:";
            // 
            // ListaBT
            // 
            this.ListaBT.Location = new System.Drawing.Point(733, 16);
            this.ListaBT.Name = "ListaBT";
            this.ListaBT.Size = new System.Drawing.Size(114, 23);
            this.ListaBT.TabIndex = 20;
            this.ListaBT.TabStop = false;
            this.ListaBT.Text = "Załaduj pełną listę";
            this.ListaBT.UseVisualStyleBackColor = true;
            this.ListaBT.Click += new System.EventHandler(this.ListaBT_Click);
            // 
            // IDTB
            // 
            this.IDTB.Location = new System.Drawing.Point(105, 27);
            this.IDTB.Name = "IDTB";
            this.IDTB.ReadOnly = true;
            this.IDTB.Size = new System.Drawing.Size(157, 20);
            this.IDTB.TabIndex = 20;
            this.IDTB.TabStop = false;
            this.IDTB.TextChanged += new System.EventHandler(this.IDTB_TextChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(20, 34);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(52, 13);
            this.IDLabel.TabIndex = 19;
            this.IDLabel.Text = "ID klienta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NrLokaluLabel);
            this.groupBox2.Controls.Add(this.NrDomuLabel);
            this.groupBox2.Controls.Add(this.NrLokaluTB);
            this.groupBox2.Controls.Add(this.NrDomuTB);
            this.groupBox2.Controls.Add(this.MailTB);
            this.groupBox2.Controls.Add(this.IDTB);
            this.groupBox2.Controls.Add(this.UsunBT);
            this.groupBox2.Controls.Add(this.ImieLabel);
            this.groupBox2.Controls.Add(this.IDLabel);
            this.groupBox2.Controls.Add(this.DodajBT);
            this.groupBox2.Controls.Add(this.ImieTB);
            this.groupBox2.Controls.Add(this.NazwiskoLabel);
            this.groupBox2.Controls.Add(this.UlicaLabel);
            this.groupBox2.Controls.Add(this.MiejscowoscLabel);
            this.groupBox2.Controls.Add(this.KodPocztLabel);
            this.groupBox2.Controls.Add(this.MailLabel);
            this.groupBox2.Controls.Add(this.KodPocztTB);
            this.groupBox2.Controls.Add(this.NazwiskoTB);
            this.groupBox2.Controls.Add(this.UlicaTB);
            this.groupBox2.Controls.Add(this.MiejscowoscTB);
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 163);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane klienta";
            // 
            // NrLokaluLabel
            // 
            this.NrLokaluLabel.AutoSize = true;
            this.NrLokaluLabel.Location = new System.Drawing.Point(451, 95);
            this.NrLokaluLabel.Name = "NrLokaluLabel";
            this.NrLokaluLabel.Size = new System.Drawing.Size(52, 13);
            this.NrLokaluLabel.TabIndex = 24;
            this.NrLokaluLabel.Text = "Nr lokalu:";
            // 
            // NrDomuLabel
            // 
            this.NrDomuLabel.AutoSize = true;
            this.NrDomuLabel.Location = new System.Drawing.Point(294, 99);
            this.NrDomuLabel.Name = "NrDomuLabel";
            this.NrDomuLabel.Size = new System.Drawing.Size(50, 13);
            this.NrDomuLabel.TabIndex = 23;
            this.NrDomuLabel.Text = "Nr domu:";
            // 
            // NrLokaluTB
            // 
            this.NrLokaluTB.Location = new System.Drawing.Point(507, 92);
            this.NrLokaluTB.Name = "NrLokaluTB";
            this.NrLokaluTB.Size = new System.Drawing.Size(52, 20);
            this.NrLokaluTB.TabIndex = 7;
            // 
            // NrDomuTB
            // 
            this.NrDomuTB.Location = new System.Drawing.Point(393, 92);
            this.NrDomuTB.Name = "NrDomuTB";
            this.NrDomuTB.Size = new System.Drawing.Size(52, 20);
            this.NrDomuTB.TabIndex = 6;
            // 
            // DodajKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 488);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DodajKlienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza klientów - Magazyn Książek";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakturaToolStripMenuItem;
        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.TextBox ImieTB;
        private System.Windows.Forms.Label NazwiskoLabel;
        private System.Windows.Forms.Label UlicaLabel;
        private System.Windows.Forms.Label MiejscowoscLabel;
        private System.Windows.Forms.Label KodPocztLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.TextBox NazwiskoTB;
        private System.Windows.Forms.TextBox MiejscowoscTB;
        private System.Windows.Forms.TextBox UlicaTB;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.Button DodajBT;
        private System.Windows.Forms.TextBox KodPocztTB;
        private System.Windows.Forms.Button UsunBT;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ListaBT;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox WyszukajTB;
        private System.Windows.Forms.Label WyszukajLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statystykiSprzedażyToolStripMenuItem;
        private System.Windows.Forms.Label NrLokaluLabel;
        private System.Windows.Forms.Label NrDomuLabel;
        private System.Windows.Forms.TextBox NrLokaluTB;
        private System.Windows.Forms.TextBox NrDomuTB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}