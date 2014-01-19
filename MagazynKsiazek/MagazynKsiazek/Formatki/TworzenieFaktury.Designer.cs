namespace MagazynKsiazek
{
    partial class TworzenieFaktury
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
            this.kToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klienciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaFakturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEdycja = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_kl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImieNazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiczbaKsiazek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.kToolStripMenuItem,
            this.klienciToolStripMenuItem,
            this.listaFakturToolStripMenuItem,
            this.zamknijToolStripMenuItem,
            this.wylogujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // kToolStripMenuItem
            // 
            this.kToolStripMenuItem.Name = "kToolStripMenuItem";
            this.kToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.kToolStripMenuItem.Text = "Baza książek";
            this.kToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_BazaKsiazek);
            // 
            // klienciToolStripMenuItem
            // 
            this.klienciToolStripMenuItem.Name = "klienciToolStripMenuItem";
            this.klienciToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.klienciToolStripMenuItem.Text = "Baza klientów";
            this.klienciToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_BazaKlientow);
            // 
            // listaFakturToolStripMenuItem
            // 
            this.listaFakturToolStripMenuItem.Name = "listaFakturToolStripMenuItem";
            this.listaFakturToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.listaFakturToolStripMenuItem.Text = "Statystyki sprzedaży";
            this.listaFakturToolStripMenuItem.Click += new System.EventHandler(this.listaFakturToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Zamknij);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(822, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 70);
            this.button4.TabIndex = 28;
            this.button4.TabStop = false;
            this.button4.Text = "Stwórz fakturę";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_StworzFakture);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(822, 44);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 64);
            this.button5.TabIndex = 30;
            this.button5.Text = "Załaduj faktury";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(822, 270);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 60);
            this.btnUsun.TabIndex = 31;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ID,
            this.ID_kl,
            this.ImieNazwisko,
            this.Data,
            this.LiczbaKsiazek,
            this.Cena});
            this.dataGridView1.Location = new System.Drawing.Point(5, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 427);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TabelaFaktur);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 448);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista faktur";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnEdycja
            // 
            this.btnEdycja.Location = new System.Drawing.Point(822, 189);
            this.btnEdycja.Name = "btnEdycja";
            this.btnEdycja.Size = new System.Drawing.Size(74, 71);
            this.btnEdycja.TabIndex = 32;
            this.btnEdycja.Text = "Edytuj fakturę";
            this.btnEdycja.UseVisualStyleBackColor = true;
            this.btnEdycja.Click += new System.EventHandler(this.btnEdycja_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 40;
            // 
            // ID
            // 
            this.ID.HeaderText = "Nr faktury";
            this.ID.Name = "ID";
            this.ID.Width = 90;
            // 
            // ID_kl
            // 
            this.ID_kl.HeaderText = "ID klienta";
            this.ID_kl.Name = "ID_kl";
            this.ID_kl.Width = 90;
            // 
            // ImieNazwisko
            // 
            this.ImieNazwisko.HeaderText = "Imię i nazwisko klienta";
            this.ImieNazwisko.Name = "ImieNazwisko";
            this.ImieNazwisko.Width = 200;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data wystawienia";
            this.Data.Name = "Data";
            this.Data.Width = 120;
            // 
            // LiczbaKsiazek
            // 
            this.LiczbaKsiazek.HeaderText = "Liczba różnych pozycji";
            this.LiczbaKsiazek.Name = "LiczbaKsiazek";
            this.LiczbaKsiazek.Width = 150;
            // 
            // Cena
            // 
            this.Cena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cena.HeaderText = "Cena faktury";
            this.Cena.Name = "Cena";
            // 
            // TworzenieFaktury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 488);
            this.ControlBox = false;
            this.Controls.Add(this.btnEdycja);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TworzenieFaktury";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tworzenie faktury - Magazyn Książek";
            this.Load += new System.EventHandler(this.TworzenieFaktury_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /*
        private void dataGridView1_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }
        */
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klienciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaFakturToolStripMenuItem;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;*/
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEdycja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_kl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImieNazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiczbaKsiazek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
    }
}