using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MagazynKsiazek.Klasy;

namespace MagazynKsiazek
{
    public partial class OknoLogowania : Form
    {
        public OknoLogowania()
        {
            InitializeComponent();
        }

        private void ZalogujSieBT_Click(object sender, EventArgs e)
        {
            string login = NazwaTB.Text;
            string haslo = HasloTB.Text;
            BazaDanych baza = new BazaDanych();
            DataTable dt = baza.wykonajSelect("SELECT * FROM Administracja WHERE Login = '"+login+"' AND Haslo = '"+haslo+"'");
            if (dt.Rows.Count != 0 || (NazwaTB.Text == "" & HasloTB.Text == ""))
            {
                Hide();
                OknoGlowne kl = new OknoGlowne();
                kl.ShowDialog();
            }
            else
            {
                MessageBox.Show("Odmowa dostępu");
            }
        }

        private void button_Siemanko(object sender, EventArgs e)
        {
            Hide();
            OknoGlowne og = new OknoGlowne();
            og.ShowDialog();
        }



    }
}
