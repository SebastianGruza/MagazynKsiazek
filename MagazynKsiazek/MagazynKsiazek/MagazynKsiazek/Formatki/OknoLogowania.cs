﻿using System;
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
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Odmowa dostępu");
            }
            else
            {
                Hide();
                OknoGlowne kl = new OknoGlowne();
                kl.ShowDialog();
            }
        }

    }
}
