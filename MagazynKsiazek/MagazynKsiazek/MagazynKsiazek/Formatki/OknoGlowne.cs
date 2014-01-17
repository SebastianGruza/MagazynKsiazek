using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazynKsiazek
{
    public partial class OknoGlowne : Form
    {

        public OknoLogowania log;
        public OknoGlowne(OknoLogowania log)
        {
            InitializeComponent();
            this.log = log;
        }

        public OknoGlowne()
        {
            InitializeComponent();
        }

        private void wyjdzToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_BazaKsiazek(object sender, EventArgs e)
        {
            Hide();
            DodajKsiazke dk = new DodajKsiazke();
            dk.ShowDialog();
        }

        private void ToolStripMenuItem_Zamknij(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz opuścić aplikację?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
            Application.Exit();

        }


        private void button_BazaKsiazek(object sender, EventArgs e)
        {
            Hide();
            DodajKsiazke ks = new DodajKsiazke();
            ks.ShowDialog();
        }

        private void button_BazaKlientow(object sender, EventArgs e)
        {
            Hide();
            DodajKlienta kl = new DodajKlienta();
            kl.ShowDialog();
        }

        private void button_TworzenieFaktury(object sender, EventArgs e)
        {
            Hide();
            TworzenieFaktury fk = new TworzenieFaktury();
            fk.ShowDialog();
        }



        private void OknoGlowne_Load(object sender, EventArgs e)
        {

        }

        private void button_StatystykiSprzedazy(object sender, EventArgs e)
        {
            Hide();
            StatystykiSprzedazy ss = new StatystykiSprzedazy();
            ss.ShowDialog();
        }

        private void wylogujToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz się wylogować?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Hide();
            OknoLogowania ol = new OknoLogowania();
            ol.ShowDialog();
        }



    }
}
