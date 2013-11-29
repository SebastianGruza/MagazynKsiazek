using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagazynKsiazek
{
    public partial class StatystykiSprzedazy : Form
    {
        public StatystykiSprzedazy()
        {
            InitializeComponent();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Wyswietl(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void ToolStripMenuItem_Start(object sender, EventArgs e)
        {
                Hide();
                OknoGlowne og = new OknoGlowne();
                og.ShowDialog();
        }

        private void ToolStripMenuItem_BazaKlientow(object sender, EventArgs e)
        {
            Hide();
            DodajKlienta kl = new DodajKlienta();
            kl.ShowDialog();
        }

        private void ToolStripMenuItem_BazaKsiazek(object sender, EventArgs e)
        {
            
            Hide();
            DodajKsiazke ks = new DodajKsiazke();
            ks.ShowDialog();
        }

        private void ToolStripMenuItem_TworzenieFaktury(object sender, EventArgs e)
        {
            Hide();
            TworzenieFaktury fk = new TworzenieFaktury();
            fk.ShowDialog();
        }

        private void ToolStripMenuItem_Zamknij(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz opuścić aplikację?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
            Application.Exit();
        }

        private void ToolStripMenuItem_Wyloguj(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz się wylogować?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Hide();
            OknoLogowania ol = new OknoLogowania();
            ol.ShowDialog();
        }

        private void comboBox_TypStatystyki(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_OdDnia(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_DoDnia(object sender, EventArgs e)
        {

        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {
                    }
    }
}
