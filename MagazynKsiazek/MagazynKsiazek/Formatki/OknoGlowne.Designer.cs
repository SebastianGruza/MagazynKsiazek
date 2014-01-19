namespace MagazynKsiazek
{
    partial class OknoGlowne
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
            this.nnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btBazaKlientow = new System.Windows.Forms.Button();
            this.btBazaKsiazek = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nnmToolStripMenuItem,
            this.wylogujToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nnmToolStripMenuItem
            // 
            this.nnmToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nnmToolStripMenuItem.Name = "nnmToolStripMenuItem";
            this.nnmToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.nnmToolStripMenuItem.Text = "Zamknij";
            this.nnmToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Zamknij);
            // 
            // wylogujToolStripMenuItem1
            // 
            this.wylogujToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.wylogujToolStripMenuItem1.Name = "wylogujToolStripMenuItem1";
            this.wylogujToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem1.Text = "Wyloguj";
            this.wylogujToolStripMenuItem1.Click += new System.EventHandler(this.wylogujToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = global::MagazynKsiazek.Properties.Resources._1384484598_web_space_px_png;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(320, 187);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(210, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Statystyki sprzedaży";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_StatystykiSprzedazy);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Image = global::MagazynKsiazek.Properties.Resources.invoice_icon__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(84, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 70);
            this.button3.TabIndex = 9;
            this.button3.Text = "Tworzenie faktury";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_TworzenieFaktury);
            // 
            // btBazaKlientow
            // 
            this.btBazaKlientow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btBazaKlientow.Image = global::MagazynKsiazek.Properties.Resources.Users_icon;
            this.btBazaKlientow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBazaKlientow.Location = new System.Drawing.Point(320, 84);
            this.btBazaKlientow.Name = "btBazaKlientow";
            this.btBazaKlientow.Size = new System.Drawing.Size(213, 70);
            this.btBazaKlientow.TabIndex = 7;
            this.btBazaKlientow.Text = "Baza klientów";
            this.btBazaKlientow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBazaKlientow.UseVisualStyleBackColor = true;
            this.btBazaKlientow.Click += new System.EventHandler(this.button_BazaKlientow);
            // 
            // btBazaKsiazek
            // 
            this.btBazaKsiazek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btBazaKsiazek.Image = global::MagazynKsiazek.Properties.Resources.glossary_icon;
            this.btBazaKsiazek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBazaKsiazek.Location = new System.Drawing.Point(84, 84);
            this.btBazaKsiazek.Name = "btBazaKsiazek";
            this.btBazaKsiazek.Size = new System.Drawing.Size(210, 70);
            this.btBazaKsiazek.TabIndex = 8;
            this.btBazaKsiazek.Text = "Baza książek";
            this.btBazaKsiazek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBazaKsiazek.UseVisualStyleBackColor = true;
            this.btBazaKsiazek.Click += new System.EventHandler(this.button_BazaKsiazek);
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 356);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btBazaKlientow);
            this.Controls.Add(this.btBazaKsiazek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "OknoGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn Książek";
            this.Load += new System.EventHandler(this.OknoGlowne_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nnmToolStripMenuItem;
        private System.Windows.Forms.Button btBazaKlientow;
        private System.Windows.Forms.Button btBazaKsiazek;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}