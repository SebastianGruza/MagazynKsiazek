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
    /// <summary>
    /// Formatka związana z wyświetlaniem statystyk sprzedaży i generowaniem raportów sprzedaży.
    /// </summary>
    public partial class StatystykiSprzedazy : Form
    {
        public StatystykiSprzedazy()
        {
            InitializeComponent();
            comboBox1.Items.Add("Zestawienie podsumowań miesięcznych sprzedaży");
            comboBox1.Items.Add("Zestawienie podsumowań tygodniowych sprzedaży");
            comboBox1.Items.Add("Najchętniej kupowane książki");
            comboBox1.Items.Add("Najaktywniejsi klienci");
            comboBox1.Items.Add("Najchętniej kupowane gatunki książek");
            comboBox1.Items.Add("Statystyki według miejscowości");
            comboBox1.SelectedIndex = 0;

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button_Wyswietl(object sender, EventArgs e)
        {
            BazaDanych baza = new BazaDanych();
            DateTime start = dateTimePicker1.Value;
            DateTime koniec = dateTimePicker2.Value;

            string zapytanie="";


            // Zestawienie podsumowań miesięcznych sprzedaży
            string zapytanie0 = @"SELECT  
                        strftime('%m-%Y', Data_Wystawienia) as 'Miesiąc, rok',                                
                        sum(sk.Liczba*sk.Cena) as 'Łączna wartość sprzedanych książek',
                        sum(sk.liczba * k.Cena) as 'Wartość zakupu książek',
                        sum(sk.liczba * (sk.Cena - k.Cena)) as 'Łączny zysk',
                        sum(sk.Liczba) as 'Liczba sprzedanych książek',
                        count (DISTINCT f.ID_Faktury) as  'Liczba wystawionych faktur'                        
                FROM    Faktury as f
                LEFT JOIN  Sprzedaz_Ksiazek as sk ON (sk.ID_Faktury=f.ID_Faktury)
                LEFT JOIN Ksiazki as k ON (sk.ID_Ksiazki=k.ISBN)
                WHERE   f.Data_Wystawienia >= '" + start.ToShortDateString() + @"'
                AND     f.Data_Wystawienia <= '" + koniec.ToShortDateString() + @"'
                GROUP BY strftime('%m-%Y', f.Data_Wystawienia)
                ORDER BY strftime('%Y', f.Data_Wystawienia), strftime('%m', f.Data_Wystawienia);";

            // Zestawienie podsumowań tygodniowych sprzedaży
            string zapytanie1 = @"SELECT  
                        strftime('%W-%Y', Data_Wystawienia) as 'Tydzień, rok',                                
                        sum(sk.Liczba*sk.Cena) as 'Łączna wartość sprzedanych książek',
                        sum(sk.liczba * k.Cena) as 'Wartość zakupu książek',
                        sum(sk.liczba * (sk.Cena - k.Cena)) as 'Łączny zysk',
                        sum(sk.Liczba) as 'Liczba sprzedanych książek',
                        count (DISTINCT f.ID_Faktury) as  'Liczba wystawionych faktur'                        
                FROM    Faktury as f
                LEFT JOIN  Sprzedaz_Ksiazek as sk ON (sk.ID_Faktury=f.ID_Faktury)
                LEFT JOIN Ksiazki as k ON (sk.ID_Ksiazki=k.ISBN)
                WHERE   f.Data_Wystawienia >= '" + start.ToShortDateString() + @"'
                AND     f.Data_Wystawienia <= '" + koniec.ToShortDateString() + @"'
                GROUP BY strftime('%W-%Y', f.Data_Wystawienia)
                ORDER BY strftime('%Y', f.Data_Wystawienia), strftime('%W', f.Data_Wystawienia);";

            // Najchętniej kupowane książki
            string zapytanie2 = @"select
                                    k.Tytul as Tytuł, k.Autor as Autor, 
                                    sum(sk.Liczba*sk.Cena) as 'Cena łączna',
                                    sum(sk.Liczba) as 'Ile razy zakupiono',
                                    count (DISTINCT f.ID_Faktury) as  'Na ilu różnych fakturach widnieje'     
                                    from Sprzedaz_Ksiazek as sk 
                                    LEFT JOIN Ksiazki as k ON (sk.ID_Ksiazki=k.ISBN)
                                    LEFT JOIN Faktury as f ON (f.ID_Faktury=sk.ID_Faktury)
                                    WHERE f.Data_Wystawienia  BETWEEN '" +
                                    start.ToShortDateString() + "' AND '" + koniec.ToShortDateString() +
                                    @"' group by sk.ID_Ksiazki
                                    order by sum(sk.Liczba*sk.Cena)  desc";

            // Najaktywniejsi klienci
            string zapytanie3 = @"select
                                    k.ID_Klienta as 'ID klienta',
                                    k.Imie as Imię, 
                                    k.Nazwisko as Nazwisko, 
                                    sum(sk.Liczba*sk.Cena) as 'Ile wydał na książki',
                                    sum(sk.Liczba) as 'Ile kupił książek',
                                    count (DISTINCT sk.ID_Ksiazki) as 'Ile kupił różnych książek',                                    
                                    count (DISTINCT f.ID_Faktury) as 'Ile faktur wystawiono'
                                    from Sprzedaz_Ksiazek as sk 
                                    LEFT JOIN Faktury as f ON (f.ID_Faktury=sk.ID_Faktury)
                                    LEFT JOIN Klienci as k ON (f.ID_Klienta=k.ID_Klienta)
                                    WHERE f.Data_Wystawienia  BETWEEN '" +
                                    start.ToShortDateString() + "' AND '" + koniec.ToShortDateString() +
                                    @"' group by k.ID_Klienta
                                    order by sum(sk.Liczba*sk.Cena)  desc";
            // Najchętniej kupowane gatunki książek
            string zapytanie4 = @"select
                                    k.Gatunek,
                                    sum(sk.Liczba*sk.Cena) as 'Cena łączna',
                                    sum(sk.Liczba) as 'Ile razy zakupiono',
                                    sum(sk.Liczba*sk.Cena)/sum(sk.Liczba)  as 'Średnia cena kupionej książki z gatunku'
                                    from Sprzedaz_Ksiazek as sk 
                                    LEFT JOIN Ksiazki as k ON (sk.ID_Ksiazki=k.ISBN)
                                    LEFT JOIN Faktury as f ON (f.ID_Faktury=sk.ID_Faktury)
                                    WHERE f.Data_Wystawienia  BETWEEN '" +
                                    start.ToShortDateString() + "' AND '" + koniec.ToShortDateString() +
                                    @"' group by k.Gatunek
                                    order by sum(sk.Liczba*sk.Cena)  desc";
            // Statystyki według miejscowości
            string zapytanie5 = @"select
                                    k.Miejscowosc as Miejscowość, 
                                    sum(sk.Liczba*sk.Cena) as 'Ile wydano na książki',
                                    sum(sk.Liczba) as 'Ile kupiono książek',                                  
                                    sum(sk.Liczba*sk.Cena)/sum(sk.Liczba)  as 'Średnia cena kupionej książki w miejscowości',                                    
                                    count (DISTINCT f.ID_Faktury) as 'Ile faktur wystawiono',       
                                    sum(sk.Liczba*sk.Cena)/count (DISTINCT f.ID_Faktury) as 'Średnia wartość faktury'
                                    from Sprzedaz_Ksiazek as sk 
                                    LEFT JOIN Faktury as f ON (f.ID_Faktury=sk.ID_Faktury)
                                    LEFT JOIN Klienci as k ON (f.ID_Klienta=k.ID_Klienta)
                                    WHERE f.Data_Wystawienia  BETWEEN '" +
                                    start.ToShortDateString() + "' AND '" + koniec.ToShortDateString() +
                                    @"' group by k.Miejscowosc
                                    order by sum(sk.Liczba*sk.Cena)  desc";

            switch (comboBox1.SelectedIndex)
	        {          
                case 0:
                    zapytanie = zapytanie0;
                    break;
                case 1:
                    zapytanie = zapytanie1;
                    break;
                case 2:
                    zapytanie = zapytanie2;
                    break;
                case 3:
                    zapytanie = zapytanie3;
                    break;
                case 4:
                    zapytanie = zapytanie4;
                    break;
                case 5:
                    zapytanie = zapytanie5;
                    break;
		        default:
                    MessageBox.Show("Wybierz typ statystyki");
                    break;     
	        } 
                

            DataTable dt = baza.wykonajSelect(zapytanie);
            this.dataGridView1.DataSource = dt;

            //dla cen - zrobienie dwóch miejsc po przecinku:
            switch (comboBox1.SelectedIndex)
	        {          
                case 0:
                    this.dataGridView1.Columns[2].DefaultCellStyle.Format = "n2";
                    this.dataGridView1.Columns[3].DefaultCellStyle.Format = "n2";
                    this.dataGridView1.Columns[4].DefaultCellStyle.Format = "n2";
                    break;
                case 1:
                    this.dataGridView1.Columns[2].DefaultCellStyle.Format = "n2";
                    this.dataGridView1.Columns[3].DefaultCellStyle.Format = "n2";
                    this.dataGridView1.Columns[4].DefaultCellStyle.Format = "n2";
                    break;
                case 2:
                    this.dataGridView1.Columns[3].DefaultCellStyle.Format = "n2";
                    break;
                case 3:
                    this.dataGridView1.Columns[4].DefaultCellStyle.Format = "n2";
                    break;
                case 4:
                    this.dataGridView1.Columns[2].DefaultCellStyle.Format = "n2";
                    this.dataGridView1.Columns[4].DefaultCellStyle.Format = "n2";
                    break;
                case 5:
                    this.dataGridView1.Columns[2].DefaultCellStyle.Format = "n2";
                    this.dataGridView1.Columns[4].DefaultCellStyle.Format = "n2";
                    this.dataGridView1.Columns[6].DefaultCellStyle.Format = "n2";
                    break;
		        default:
                    MessageBox.Show("Wybierz typ statystyki");
                    break;     
	        } 
            
            
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

        private void StatystykiSprzedazy_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }
    }
}
