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
            connection = new SQLiteConnection(@"Data Source=C:\Users\Siena\Desktop\MagazynKsiazek\MagazynKsiazek\bin\Debug\magazyn.db");
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
                myCommand.CommandText = "INSERT INTO Klienci(Imie, Nazwisko, Email, Miejscowosc, Ulica, NrDomu, NrLokalu, KodPocztowy) VALUES('"+klient.Imie+"','"+klient.Nazwisko+"','"+klient.Email+"','"+klient.Miejscowosc+"','"+klient.Ulica+"','"+klient.NrDomu+"','"+klient.NrLokalu+"','"+klient.KodPocztowy+"')";
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
                myCommand.CommandText = "UPDATE Klienci SET "+colName+" = '"+newValue+"' WHERE ID_Klienta = '"+id+"'";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        #endregion

        #region Ksiazka
        #endregion

        #region Faktura
        #endregion



    }
}
