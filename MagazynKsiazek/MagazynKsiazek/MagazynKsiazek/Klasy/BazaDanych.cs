using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

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
                myCommand.CommandText = "INSERT INTO Ksiazki(Tytul, ID_Autora, Wydawnictwo, RokWydania, Gatunek, Ilosc, Cena) VALUES('" + ksiazka.Tytul + "','" + ksiazka.DaneAutora + "','" + ksiazka.Wydawnictwo + "','" + ksiazka.RokWydania + "','" + ksiazka.Gatunek + "','" + ksiazka.Ilosc + "','" + ksiazka.Cena + "')";
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
        #endregion



        }
    }

