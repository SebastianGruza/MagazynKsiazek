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
            this.VTowar = new System.Windows.Forms.ComboBox();
            this.VCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BZapisz = new System.Windows.Forms.Button();
            this.BAnuluj = new System.Windows.Forms.Button();
            this.VNazwa = new System.Windows.Forms.TextBox();
            this.VKod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.VIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // VIlosc
            // 
            this.VIlosc.Location = new System.Drawing.Point(135, 220);
            this.VIlosc.Name = "VIlosc";
            this.VIlosc.Size = new System.Drawing.Size(254, 20);
            this.VIlosc.TabIndex = 23;
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
            // VTowar
            // 
            this.VTowar.FormattingEnabled = true;
            this.VTowar.Location = new System.Drawing.Point(135, 12);
            this.VTowar.Name = "VTowar";
            this.VTowar.Size = new System.Drawing.Size(254, 21);
            this.VTowar.TabIndex = 18;
            this.VTowar.Text = "Wybierz książkę z listy";
            // 
            // VCena
            // 
            this.VCena.Location = new System.Drawing.Point(135, 272);
            this.VCena.Name = "VCena";
            this.VCena.ReadOnly = true;
            this.VCena.Size = new System.Drawing.Size(254, 20);
            this.VCena.TabIndex = 24;
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
            // 
            // VNazwa
            // 
            this.VNazwa.Location = new System.Drawing.Point(135, 65);
            this.VNazwa.Name = "VNazwa";
            this.VNazwa.ReadOnly = true;
            this.VNazwa.Size = new System.Drawing.Size(254, 20);
            this.VNazwa.TabIndex = 22;
            // 
            // VKod
            // 
            this.VKod.Location = new System.Drawing.Point(135, 39);
            this.VKod.Name = "VKod";
            this.VKod.ReadOnly = true;
            this.VKod.Size = new System.Drawing.Size(254, 20);
            this.VKod.TabIndex = 20;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 33;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(254, 20);
            this.textBox3.TabIndex = 35;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(254, 20);
            this.textBox4.TabIndex = 37;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 169);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(254, 20);
            this.textBox5.TabIndex = 39;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(135, 195);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(254, 20);
            this.textBox6.TabIndex = 41;
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
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(135, 246);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(254, 20);
            this.numericUpDown1.TabIndex = 43;
            // 
            // EdycjaPozycji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 352);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VIlosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VTowar);
            this.Controls.Add(this.VCena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BZapisz);
            this.Controls.Add(this.BAnuluj);
            this.Controls.Add(this.VNazwa);
            this.Controls.Add(this.VKod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EdycjaPozycji";
            this.Text = "Edycja pozycji";
            ((System.ComponentModel.ISupportInitialize)(this.VIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown VIlosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VTowar;
        private System.Windows.Forms.TextBox VCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BZapisz;
        private System.Windows.Forms.Button BAnuluj;
        private System.Windows.Forms.TextBox VNazwa;
        private System.Windows.Forms.TextBox VKod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}