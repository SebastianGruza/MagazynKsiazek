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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(355, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Dodaj);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Aktualizuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Aktualizuj);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Usun);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Klient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker_Data);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Klient);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(115, 143);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(52, 20);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox_KodPocztowy);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(115, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(158, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox_Miejscowosc);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(158, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox_Ulica);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kod pocztowy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Miejscowość:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ulica:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(115, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(158, 20);
            this.textBox6.TabIndex = 21;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox_IDKlienta);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID klienta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(452, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 192);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nabywca";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(6, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TabelaFaktur);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Klient";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Towar";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ilość (szt.)";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cena";
            this.Column5.Name = "Column5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(10, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 155);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj książkę";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(94, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tytul);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(94, 60);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(212, 20);
            this.textBoxISBN.TabIndex = 29;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBox_ISBN);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(94, 86);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown_Ilosc);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 60);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "ISBN:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(94, 112);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(120, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox_Cena);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ilość (szt.):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tytuł książki:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(822, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 208);
            this.button4.TabIndex = 28;
            this.button4.Text = "Stwórz fakturę";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_StworzFakture);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 448);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stwórz fakturę";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Zamknij);
            // 
            // TworzenieFaktury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 488);
            this.ControlBox = false;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klienciToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem listaFakturToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
    }
}