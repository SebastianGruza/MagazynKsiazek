namespace MagazynKsiazek.Formatki
{
    partial class EdycjaFaktury
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMiejscowosc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GListaTowarow = new System.Windows.Forms.DataGridView();
            this.CISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTytul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIlosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaSprzedaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCenaRazem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCena = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GListaTowarow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMiejscowosc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtUlica);
            this.groupBox2.Controls.Add(this.txtKod);
            this.groupBox2.Location = new System.Drawing.Point(454, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 167);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nabywca";
            // 
            // txtMiejscowosc
            // 
            this.txtMiejscowosc.Location = new System.Drawing.Point(115, 109);
            this.txtMiejscowosc.Name = "txtMiejscowosc";
            this.txtMiejscowosc.ReadOnly = true;
            this.txtMiejscowosc.Size = new System.Drawing.Size(200, 20);
            this.txtMiejscowosc.TabIndex = 18;
            this.txtMiejscowosc.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Klient:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.TabStop = false;
            this.comboBox1.Text = "Wybierz klienta z listy";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Miejscowość:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 57);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(52, 20);
            this.txtID.TabIndex = 21;
            this.txtID.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kod pocztowy:";
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
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(115, 83);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.ReadOnly = true;
            this.txtUlica.Size = new System.Drawing.Size(200, 20);
            this.txtUlica.TabIndex = 17;
            this.txtUlica.TabStop = false;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(115, 135);
            this.txtKod.Name = "txtKod";
            this.txtKod.ReadOnly = true;
            this.txtKod.Size = new System.Drawing.Size(52, 20);
            this.txtKod.TabIndex = 19;
            this.txtKod.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 268);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj książkę do faktury";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(423, 200);
            this.listBox1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(159, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(569, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // GListaTowarow
            // 
            this.GListaTowarow.AllowUserToAddRows = false;
            this.GListaTowarow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GListaTowarow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CISBN,
            this.CTytul,
            this.CAutor,
            this.CIlosc,
            this.CenaSprzedaz,
            this.CCenaRazem});
            this.GListaTowarow.Location = new System.Drawing.Point(12, 285);
            this.GListaTowarow.MultiSelect = false;
            this.GListaTowarow.Name = "GListaTowarow";
            this.GListaTowarow.RowHeadersVisible = false;
            this.GListaTowarow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GListaTowarow.Size = new System.Drawing.Size(633, 206);
            this.GListaTowarow.TabIndex = 32;
            // 
            // CISBN
            // 
            this.CISBN.FillWeight = 150F;
            this.CISBN.HeaderText = "ISBN";
            this.CISBN.Name = "CISBN";
            this.CISBN.ReadOnly = true;
            this.CISBN.Width = 60;
            // 
            // CTytul
            // 
            this.CTytul.HeaderText = "Tytuł";
            this.CTytul.Name = "CTytul";
            this.CTytul.ReadOnly = true;
            this.CTytul.Width = 150;
            // 
            // CAutor
            // 
            this.CAutor.HeaderText = "Autor";
            this.CAutor.Name = "CAutor";
            this.CAutor.ReadOnly = true;
            this.CAutor.Width = 150;
            // 
            // CIlosc
            // 
            this.CIlosc.HeaderText = "Ilość";
            this.CIlosc.Name = "CIlosc";
            this.CIlosc.ReadOnly = true;
            this.CIlosc.Width = 50;
            // 
            // CenaSprzedaz
            // 
            this.CenaSprzedaz.HeaderText = "Cena sprzedaży";
            this.CenaSprzedaz.Name = "CenaSprzedaz";
            this.CenaSprzedaz.Width = 110;
            // 
            // CCenaRazem
            // 
            this.CCenaRazem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCenaRazem.HeaderText = "Cena razem";
            this.CCenaRazem.Name = "CCenaRazem";
            this.CCenaRazem.ReadOnly = true;
            // 
            // lblCena
            // 
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCena.Location = new System.Drawing.Point(668, 396);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(124, 24);
            this.lblCena.TabIndex = 34;
            this.lblCena.Text = "0,00 zł";
            this.lblCena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(675, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 24);
            this.label11.TabIndex = 33;
            this.label11.Text = "Cena razem:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 35;
            this.button2.Text = "Edycja pozycji";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 32);
            this.button3.TabIndex = 36;
            this.button3.Text = "Usuń pozycję";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(454, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(331, 46);
            this.button4.TabIndex = 37;
            this.button4.Text = "Zapisz fakturę w bazie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EdycjaFaktury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 503);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GListaTowarow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "EdycjaFaktury";
            this.Text = "Edycja faktury";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GListaTowarow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMiejscowosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView GListaTowarow;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTytul;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIlosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaSprzedaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCenaRazem;
    }
}