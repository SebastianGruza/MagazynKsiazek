using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace MagazynKsiazek.Klasy
{
    class BazaDanych
    {
        private SQLiteConnection connection;

        public BazaDanych()
        {
            connection = new SQLiteConnection(@"Data Source=magazyn.db");
        }

        #region Klient

        public DataTable wykonajSelect(string query)
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da;

            try
            {
                SQLiteCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = query;
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                connection.Close();
            }
            catch (SQLiteException ex)
            {
            }
            catch (Exception ex2)
            {
            }

            return dt;
        }

        public void DodajKlienta(Klient klient)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "INSERT INTO Klienci(Imie, Nazwisko, Email, Miejscowosc, Ulica, NrDomu, NrLokalu, KodPocztowy) VALUES('" + klient.Imie + "','" + klient.Nazwisko + "','" + klient.Email + "','" + klient.Miejscowosc + "','" + klient.Ulica + "','" + klient.NrDomu + "','" + klient.NrLokalu + "','" + klient.KodPocztowy + "')";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UsunKlienta(int id)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "DELETE FROM Klienci WHERE ID_Klienta = '" + id + "'";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void EdytujKlienta(int id, string colName, string newValue)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "UPDATE Klienci SET " + colName + " = '" + newValue + "' WHERE ID_Klienta = '" + id + "'";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        #endregion

        #region Ksiazka
        public DataTable wykonajSelectKsiazki(string query)
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da;

            try
            {
                SQLiteCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = query;
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                connection.Close();
            }
            catch (SQLiteException ex)
            {
            }
            catch (Exception ex2)
            {
            }

            return dt;
        }

        public void DodajKsiazke(Ksiazki ksiazka)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "INSERT INTO Ksiazki(Tytul, Autor, Wydawnictwo, RokWydania, Gatunek, Ilosc, Cena) VALUES('" + ksiazka.Tytul + "','" + ksiazka.DaneAutora + "','" + ksiazka.Wydawnictwo + "','" + ksiazka.RokWydania + "','" + ksiazka.Gatunek + "','" + ksiazka.Ilosc + "','" + ksiazka.Cena + "')";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UsunKsiazke(int isbn)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "DELETE FROM Ksiazki WHERE ISBN = '" + isbn + "'";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void EdytujKsiazke(int isbn, string colName, string newValue)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "UPDATE Ksiazki SET " + colName + " = '" + newValue + "' WHERE ISBN = '" + isbn + "'";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        #endregion

        #region Faktura

        internal IList<Faktura> pobierzListeFaktur()
        {
            IList<Faktura> listaFaktur = new List<Faktura>();

            try
            {
                SQLiteCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText =
                "select f.ID_Faktury,  f.Data_Wystawienia, f.ID_Klienta " +
                " from Faktury as f " +
                " order by f.Data_Wystawienia";

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader != null && reader.Read())
                {

                    Faktura fak = new Faktura();
                    fak.Id = reader.GetInt32(0); ;
                    fak.Data = reader.GetDateTime(1);
                    fak.ID_Klienta = reader.GetInt32(2);

                    listaFaktur.Add(fak);
                }

                reader.Close();
                connection.Close();


                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText =
                "select sk.ID_Faktury, sk.ID_Sprzedazy,   sk.Liczba, sk.ID_Ksiazki, sk.Cena " +
                " from Sprzedaz_Ksiazek as sk " +
                " order by sk.ID_Faktury";

                reader = cmd.ExecuteReader();
                List<int> Id_sprzedanychKsiazek = new List<int>();
                listaFaktur[0].listaSprzedanychKsiazek = new List<SprzedazKsiazek>();
                int licznik = 0;
                while (reader != null && reader.Read())
                {
                    int id = reader.GetInt32(0);

                    for (licznik = 0; licznik < listaFaktur.Count; licznik++)
                    {
                        if (listaFaktur[licznik].Id == id)
                            break;
                    }
                    SprzedazKsiazek sprz_ksi = new SprzedazKsiazek();
                    sprz_ksi.Id = reader.GetInt32(1);
                    sprz_ksi.Ilosc = reader.GetInt32(2);
                    sprz_ksi.IdKsiazki = reader.GetInt32(3);
                    sprz_ksi.Cena = reader.GetInt32(4);


                    listaFaktur[licznik].listaSprzedanychKsiazek.Add(sprz_ksi);
                }

                reader.Close();
                connection.Close();

                for (int i = 0; i < listaFaktur.Count; i++)
                {
                    for (int j = 0; j < listaFaktur[i].listaSprzedanychKsiazek.Count; j++)
                    {
                       // listaFaktur[i].listaSprzedanychKsiazek[j].ksi = pobierzKsiazkePoId(listaFaktur[i].listaSprzedanychKsiazek[j].IdTow);
                    }

                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            return listaFaktur;
        }


        /*
        public DataTable wykonajSelectFaktura(string query)
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da;

            try
            {
                SQLiteCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = query;
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                connection.Close();
            }
            catch (SQLiteException ex)
            {
            }
            catch (Exception ex2)
            {
            }

            return dt;
        }
        public void DodajFakture(Faktura faktura)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "INSERT INTO Faktury(ID_Klienta, ID_Faktury, Data_Wystawienia, Nr_Faktury, Klient, Towar, Ilosc, Cena) VALUES('" + faktura.ID_Klienta + "','" + faktura.ID_Faktury + "','" + faktura.Data_Wystawienia + "','" + faktura.Nr_Faktury + "','" + faktura.Klient + "','" + faktura.Towar + "','" + faktura.Ilosc + "','" + faktura.Cena + "')";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void UsunFakture(int id_faktury)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "DELETE FROM Faktury WHERE ID_Faktury = '" + id_faktury + "'";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void EdytujFakture(int id_faktury, string colName, string newValue)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "UPDATE Faktury SET " + colName + " = '" + newValue + "' WHERE ID_Faktury = '" + id_faktury + "'";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
        
        */
        #endregion

    }
    }

