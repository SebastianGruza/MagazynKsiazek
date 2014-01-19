namespace MagazynKsiazek.Formatki
{
    partial class EdycjaPozycji
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
            this.VIlosc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.VPozycja = new System.Windows.Forms.ComboBox();
            this.VCenaRazem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BZapisz = new System.Windows.Forms.Button();
            this.BAnuluj = new System.Windows.Forms.Button();
            this.VTytul = new System.Windows.Forms.TextBox();
            this.VAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VIloscMag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VCenaHurt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.VGat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.VRok = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.VWydawnictwo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.VCenaZak = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.VIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCenaZak)).BeginInit();
            this.SuspendLayout();
            // 
            // VIlosc
            // 
            this.VIlosc.Location = new System.Drawing.Point(135, 220);
            this.VIlosc.Name = "VIlosc";
            this.VIlosc.Size = new System.Drawing.Size(277, 20);
            this.VIlosc.TabIndex = 23;
            this.VIlosc.ValueChanged += new System.EventHandler(this.VIlosc_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Książka:";
            // 
            // VPozycja
            // 
            this.VPozycja.FormattingEnabled = true;
            this.VPozycja.Location = new System.Drawing.Point(135, 12);
            this.VPozycja.Name = "VPozycja";
            this.VPozycja.Size = new System.Drawing.Size(277, 21);
            this.VPozycja.TabIndex = 18;
            this.VPozycja.Text = "Wybierz książkę z listy";
            this.VPozycja.SelectedIndexChanged += new System.EventHandler(this.VPozycja_SelectedIndexChanged);
            // 
            // VCenaRazem
            // 
            this.VCenaRazem.Location = new System.Drawing.Point(135, 272);
            this.VCenaRazem.Name = "VCenaRazem";
            this.VCenaRazem.ReadOnly = true;
            this.VCenaRazem.Size = new System.Drawing.Size(277, 20);
            this.VCenaRazem.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cena razem:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ilość zakupionych:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BZapisz
            // 
            this.BZapisz.Location = new System.Drawing.Point(135, 298);
            this.BZapisz.Name = "BZapisz";
            this.BZapisz.Size = new System.Drawing.Size(75, 23);
            this.BZapisz.TabIndex = 26;
            this.BZapisz.Text = "Zapisz";
            this.BZapisz.UseVisualStyleBackColor = true;
            this.BZapisz.Click += new System.EventHandler(this.BZapisz_Click);
            // 
            // BAnuluj
            // 
            this.BAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BAnuluj.Location = new System.Drawing.Point(216, 298);
            this.BAnuluj.Name = "BAnuluj";
            this.BAnuluj.Size = new System.Drawing.Size(75, 23);
            this.BAnuluj.TabIndex = 27;
            this.BAnuluj.Text = "Anuluj";
            this.BAnuluj.UseVisualStyleBackColor = true;
            this.BAnuluj.Click += new System.EventHandler(this.BAnuluj_Click);
            // 
            // VTytul
            // 
            this.VTytul.Location = new System.Drawing.Point(135, 65);
            this.VTytul.Name = "VTytul";
            this.VTytul.ReadOnly = true;
            this.VTytul.Size = new System.Drawing.Size(277, 20);
            this.VTytul.TabIndex = 22;
            // 
            // VAutor
            // 
            this.VAutor.Location = new System.Drawing.Point(135, 39);
            this.VAutor.Name = "VAutor";
            this.VAutor.ReadOnly = true;
            this.VAutor.Size = new System.Drawing.Size(277, 20);
            this.VAutor.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tytuł:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cena za sztukę:";
            // 
            // VIloscMag
            // 
            this.VIloscMag.Location = new System.Drawing.Point(135, 91);
            this.VIloscMag.Name = "VIloscMag";
            this.VIloscMag.ReadOnly = true;
            this.VIloscMag.Size = new System.Drawing.Size(277, 20);
            this.VIloscMag.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Ilość w magazynie:";
            // 
            // VCenaHurt
            // 
            this.VCenaHurt.Location = new System.Drawing.Point(135, 117);
            this.VCenaHurt.Name = "VCenaHurt";
            this.VCenaHurt.ReadOnly = true;
            this.VCenaHurt.Size = new System.Drawing.Size(277, 20);
            this.VCenaHurt.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Cena hurtowa:";
            // 
            // VGat
            // 
            this.VGat.Location = new System.Drawing.Point(135, 143);
            this.VGat.Name = "VGat";
            this.VGat.ReadOnly = true;
            this.VGat.Size = new System.Drawing.Size(277, 20);
            this.VGat.TabIndex = 37;
            this.VGat.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Gatunek:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // VRok
            // 
            this.VRok.Location = new System.Drawing.Point(135, 169);
            this.VRok.Name = "VRok";
            this.VRok.ReadOnly = true;
            this.VRok.Size = new System.Drawing.Size(277, 20);
            this.VRok.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Rok wydania:";
            // 
            // VWydawnictwo
            // 
            this.VWydawnictwo.Location = new System.Drawing.Point(135, 195);
            this.VWydawnictwo.Name = "VWydawnictwo";
            this.VWydawnictwo.ReadOnly = true;
            this.VWydawnictwo.Size = new System.Drawing.Size(277, 20);
            this.VWydawnictwo.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Wydawnictwo:";
            // 
            // VCenaZak
            // 
            this.VCenaZak.DecimalPlaces = 2;
            this.VCenaZak.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.VCenaZak.Location = new System.Drawing.Point(135, 246);
            this.VCenaZak.Name = "VCenaZak";
            this.VCenaZak.Size = new System.Drawing.Size(277, 20);
            this.VCenaZak.TabIndex = 43;
            this.VCenaZak.ValueChanged += new System.EventHandler(this.VCenaZak_ValueChanged);
            // 
            // EdycjaPozycji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 352);
            this.Controls.Add(this.VCenaZak);
            this.Controls.Add(this.VWydawnictwo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VRok);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VGat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.VCenaHurt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VIloscMag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VIlosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VPozycja);
            this.Controls.Add(this.VCenaRazem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BZapisz);
            this.Controls.Add(this.BAnuluj);
            this.Controls.Add(this.VTytul);
            this.Controls.Add(this.VAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EdycjaPozycji";
            this.Text = "Edycja pozycji";
            ((System.ComponentModel.ISupportInitialize)(this.VIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCenaZak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown VIlosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VPozycja;
        private System.Windows.Forms.TextBox VCenaRazem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BZapisz;
        private System.Windows.Forms.Button BAnuluj;
        private System.Windows.Forms.TextBox VTytul;
        private System.Windows.Forms.TextBox VAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VIloscMag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VCenaHurt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox VGat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox VRok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox VWydawnictwo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown VCenaZak;
    }
}