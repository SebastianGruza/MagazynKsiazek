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
            this.VJM = new System.Windows.Forms.TextBox();
            this.VNazwa = new System.Windows.Forms.TextBox();
            this.VKod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VIlosc)).BeginInit();
            this.SuspendLayout();
            // 
            // VIlosc
            // 
            this.VIlosc.Location = new System.Drawing.Point(135, 115);
            this.VIlosc.Name = "VIlosc";
            this.VIlosc.Size = new System.Drawing.Size(140, 20);
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
            this.VCena.Location = new System.Drawing.Point(135, 166);
            this.VCena.Name = "VCena";
            this.VCena.ReadOnly = true;
            this.VCena.Size = new System.Drawing.Size(254, 20);
            this.VCena.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cena razem:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ilość zakupionych:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BZapisz
            // 
            this.BZapisz.Location = new System.Drawing.Point(124, 190);
            this.BZapisz.Name = "BZapisz";
            this.BZapisz.Size = new System.Drawing.Size(75, 23);
            this.BZapisz.TabIndex = 26;
            this.BZapisz.Text = "Zapisz";
            this.BZapisz.UseVisualStyleBackColor = true;
            // 
            // BAnuluj
            // 
            this.BAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BAnuluj.Location = new System.Drawing.Point(205, 190);
            this.BAnuluj.Name = "BAnuluj";
            this.BAnuluj.Size = new System.Drawing.Size(75, 23);
            this.BAnuluj.TabIndex = 27;
            this.BAnuluj.Text = "Anuluj";
            this.BAnuluj.UseVisualStyleBackColor = true;
            // 
            // VJM
            // 
            this.VJM.Location = new System.Drawing.Point(281, 115);
            this.VJM.Name = "VJM";
            this.VJM.ReadOnly = true;
            this.VJM.Size = new System.Drawing.Size(108, 20);
            this.VJM.TabIndex = 25;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 144);
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
            // EdycjaPozycji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 276);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VIlosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VTowar);
            this.Controls.Add(this.VCena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BZapisz);
            this.Controls.Add(this.BAnuluj);
            this.Controls.Add(this.VJM);
            this.Controls.Add(this.VNazwa);
            this.Controls.Add(this.VKod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EdycjaPozycji";
            this.Text = "Edycja pozycji";
            ((System.ComponentModel.ISupportInitialize)(this.VIlosc)).EndInit();
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
        private System.Windows.Forms.TextBox VJM;
        private System.Windows.Forms.TextBox VNazwa;
        private System.Windows.Forms.TextBox VKod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
    }
}