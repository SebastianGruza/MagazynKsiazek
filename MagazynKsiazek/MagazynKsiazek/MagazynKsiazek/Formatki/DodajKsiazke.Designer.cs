﻿namespace MagazynKsiazek
{
    partial class RokWydaniaTB
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
            this.DodajBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TytulTB = new System.Windows.Forms.TextBox();
            this.AutorTB = new System.Windows.Forms.TextBox();
            this.WydawnictwoTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IloscTB = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CenaTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.isbnTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RokTB = new System.Windows.Forms.TextBox();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.klienciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakturyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykiSprzedazyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsunTB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WyszukajTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ListaBT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GatunekTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IloscTB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DodajBT
            // 
            this.DodajBT.Location = new System.Drawing.Point(629, 23);
            this.DodajBT.Name = "DodajBT";
            this.DodajBT.Size = new System.Drawing.Size(75, 23);
            this.DodajBT.TabIndex = 8;
            this.DodajBT.Text = "Dodaj";
            this.DodajBT.UseVisualStyleBackColor = true;
            this.DodajBT.Click += new System.EventHandler(this.DodajBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tytuł:";
            // 
            // TytulTB
            // 
            this.TytulTB.Location = new System.Drawing.Point(118, 56);
            this.TytulTB.Name = "TytulTB";
            this.TytulTB.Size = new System.Drawing.Size(223, 20);
            this.TytulTB.TabIndex = 1;
            
            // 
            // AutorTB
            // 
            this.AutorTB.Location = new System.Drawing.Point(118, 82);
            this.AutorTB.Name = "AutorTB";
            this.AutorTB.Size = new System.Drawing.Size(223, 20);
            this.AutorTB.TabIndex = 2;
            
            // 
            // WydawnictwoTB
            // 
            this.WydawnictwoTB.Location = new System.Drawing.Point(118, 108);
            this.WydawnictwoTB.Name = "WydawnictwoTB";
            this.WydawnictwoTB.Size = new System.Drawing.Size(223, 20);
            this.WydawnictwoTB.TabIndex = 3;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ilość:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gatunek:";
            // 
            // IloscTB
            // 
            this.IloscTB.Location = new System.Drawing.Point(435, 61);
            this.IloscTB.Name = "IloscTB";
            this.IloscTB.Size = new System.Drawing.Size(121, 20);
            this.IloscTB.TabIndex = 6;
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cena:";
            // 
            // CenaTB
            // 
            this.CenaTB.Location = new System.Drawing.Point(435, 91);
            this.CenaTB.Name = "CenaTB";
            this.CenaTB.Size = new System.Drawing.Size(121, 20);
            this.CenaTB.TabIndex = 7;
           
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 27);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ISBN:";
            // 
            // isbnTB
            // 
            this.isbnTB.Location = new System.Drawing.Point(118, 27);
            this.isbnTB.Name = "isbnTB";
            this.isbnTB.ReadOnly = true;
            this.isbnTB.Size = new System.Drawing.Size(223, 20);
            this.isbnTB.TabIndex = 17;
            this.isbnTB.TabStop = false;
            
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 108);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Wydawnictwo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 134);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Rok wydania:";
            // 
            // RokTB
            // 
            this.RokTB.Location = new System.Drawing.Point(118, 134);
            this.RokTB.Name = "RokTB";
            this.RokTB.Size = new System.Drawing.Size(223, 20);
            this.RokTB.TabIndex = 4;
            
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.klienciToolStripMenuItem,
            this.fakturyToolStripMenuItem,
            this.statystykiSprzedazyToolStripMenuItem,
            this.zamknijToolStripMenuItem,
            this.wylogujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // klienciToolStripMenuItem
            // 
            this.klienciToolStripMenuItem.Name = "klienciToolStripMenuItem";
            this.klienciToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.klienciToolStripMenuItem.Text = "Baza klientów";
            this.klienciToolStripMenuItem.Click += new System.EventHandler(this.klienciToolStripMenuItem_Click);
            // 
            // fakturyToolStripMenuItem
            // 
            this.fakturyToolStripMenuItem.Name = "fakturyToolStripMenuItem";
            this.fakturyToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.fakturyToolStripMenuItem.Text = "Tworzenie faktury";
            this.fakturyToolStripMenuItem.Click += new System.EventHandler(this.fakturyToolStripMenuItem_Click);
            // 
            // statystykiSprzedazyToolStripMenuItem
            // 
            this.statystykiSprzedazyToolStripMenuItem.Name = "statystykiSprzedazyToolStripMenuItem";
            this.statystykiSprzedazyToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.statystykiSprzedazyToolStripMenuItem.Text = "Statystyki sprzedaży";
            this.statystykiSprzedazyToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_StatystykiSprzedazy);
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
            // UsunTB
            // 
            this.UsunTB.Location = new System.Drawing.Point(629, 19);
            this.UsunTB.Name = "UsunTB";
            this.UsunTB.Size = new System.Drawing.Size(75, 23);
            this.UsunTB.TabIndex = 10;
            this.UsunTB.Text = "Usuń";
            this.UsunTB.UseVisualStyleBackColor = true;
            this.UsunTB.Click += new System.EventHandler(this.UsunTB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.WyszukajTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UsunTB);
            this.groupBox1.Controls.Add(this.ListaBT);
            this.groupBox1.Location = new System.Drawing.Point(25, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 272);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukiwanie";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(21, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(829, 202);
            this.dataGridView1.TabIndex = 29;
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
            // WyszukajTB
            // 
            this.WyszukajTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.WyszukajTB.Location = new System.Drawing.Point(224, 19);
            this.WyszukajTB.Name = "WyszukajTB";
            this.WyszukajTB.Size = new System.Drawing.Size(205, 20);
            this.WyszukajTB.TabIndex = 28;
            this.WyszukajTB.TabStop = false;
            this.WyszukajTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WyszukajTB.TextChanged += new System.EventHandler(this.WyszukajTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Wyszukaj:";
            // 
            // ListaBT
            // 
            this.ListaBT.Location = new System.Drawing.Point(720, 19);
            this.ListaBT.Name = "ListaBT";
            this.ListaBT.Size = new System.Drawing.Size(114, 23);
            this.ListaBT.TabIndex = 25;
            this.ListaBT.TabStop = false;
            this.ListaBT.Text = "Załaduj pełną listę";
            this.ListaBT.UseVisualStyleBackColor = true;
            this.ListaBT.Click += new System.EventHandler(this.ListaBT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GatunekTB);
            this.groupBox2.Controls.Add(this.WydawnictwoTB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TytulTB);
            this.groupBox2.Controls.Add(this.AutorTB);
            this.groupBox2.Controls.Add(this.DodajBT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RokTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.IloscTB);
            this.groupBox2.Controls.Add(this.isbnTB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CenaTB);
            this.groupBox2.Location = new System.Drawing.Point(25, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 173);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane książki";
            // 
            // GatunekTB
            // 
            this.GatunekTB.Location = new System.Drawing.Point(435, 29);
            this.GatunekTB.Name = "GatunekTB";
            this.GatunekTB.Size = new System.Drawing.Size(133, 20);
            this.GatunekTB.TabIndex = 20;
            // 
            // RokWydaniaTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 488);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RokWydaniaTB";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza książek - Magazyn Książek";
            ((System.ComponentModel.ISupportInitialize)(this.IloscTB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TytulTB;
        private System.Windows.Forms.TextBox AutorTB;
        private System.Windows.Forms.TextBox WydawnictwoTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IloscTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CenaTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox isbnTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RokTB;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button UsunTB;
        private System.Windows.Forms.ToolStripMenuItem klienciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakturyToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ListaBT;
        private System.Windows.Forms.TextBox WyszukajTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem statystykiSprzedazyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.TextBox GatunekTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}