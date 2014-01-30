using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace MagazynKsiazek.Klasy
{
    /// <summary>
    /// Klasa pozwala na łączenie z bazą danych oraz wszelkie operacje dotyczące zapisu/odczytu
    /// w bazie danych: pobieranie z bazy poszczególnych rekordów, wyszukiwanie, edycję, usuwanie,
    /// dodawanie.
    /// </summary>
    class BazaDanych
    {
        private SQLiteConnection connection;

        /// <summary>
        /// Konstruktor odpowiedzialny za tworzenie nowego połączenia z bazą danych SQLite, 
        /// a konkretnie z plikiem 'magazyn.db'.
        /// </summary>
        public BazaDanych()
        {
            connection = new SQLiteConnection(@"Data Source=magazyn.db");
        }

        #region Klient
        /// <summary>
        /// Metoda pozwala na zapytania do bazy danych w rodzaju 'SELECT ...' i wyświetla wyniki
        /// w formie tabelki 'DataTable'.
        /// </summary>
        /// <param name="query">zapytanie dane silnikowi baz danych SQLite</param>
        /// <returns>tabelka ze zwróconymi wynikami zapytania</returns>
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

        /// <summary>
        /// Pozwala na dodanie do bazy danych 'klienta' poprzez wewnętrzne zapytania SQL 'INSERT INTO ...'.
        /// </summary>
        /// <param name="klient"> dodawany obiekt 'klienta' do bazy</param>
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


        /// <summary>
        /// Umożliwia usuwanie klienta z bazy danych o podanym id.
        /// </summary>
        /// <param name="id"> - id klienta, którego chcemy usunąć z bazy danych</param>
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

        /// <summary>
        /// Pozwala na edycję danych klienta użycie wewnętrznie zapytania 'UPDATE...'
        /// </summary>
        /// <param name="id">id edytowanego klienta</param>
        /// <param name="colName">nazwa kolumny, którego atrybut zmieniamy</param>
        /// <param name="newValue">nowa wartość atrybutu klienta dla zmienianej kolumny</param>
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

        /// <summary>
        /// Pozwala na wyszukanie w bazie danych i zwrócenie klienta po jego id w bazie danych.
        /// </summary>
        /// <param name="p">id klienta, którego chcemy znaleźć w bazie danych</param>
        /// <returns>obiekt zwracanego klienta</returns>
        private Klient pobierzKlientaPoId(int p)
        {

            Klient klient = null;

            try
            {
                SQLiteCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "select k.ID_Klienta, k.Imie, k.Nazwisko, k.Email, k.Miejscowosc, k.Ulica, k.NrDomu, k.NrLokalu, k.KodPocztowy  " +
                " from Klienci as k " +
                " WHERE k.ID_Klienta = " + p;

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader != null && reader.Read())
                {
                    klient = new Klient();
                    klient.ID_Klienta = reader.GetInt32(0);
                    klient.Imie = reader.GetString(1);
                    klient.Nazwisko= reader.GetString(2);
                    klient.Email = reader.GetString(3);
                    klient.Miejscowosc = reader.GetString(4);
                    klient.Ulica = reader.GetString(5);
                    klient.NrDomu = reader.GetString(6);
                    klient.NrLokalu = reader.GetString(7);
                    klient.KodPocztowy = reader.GetString(8);

                    reader.Close();
                }

                connection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }

            return klient;
        }

        /// <summary>
        /// Pozwala na 'hurtowe' pobranie listy wszystkich klientów z bazy danych.
        /// </summary>
        /// <returns>pobrana z bazy lista wszystkich klientów</returns>
        internal IList<Klient> pobierzListeKlientow()
        {
            IList<Klient> listaKlientow = new List<Klient>();

            try
            {
                SQLiteCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText =
                "select k. ID_Klienta, k.Imie, k.Nazwisko, k.Email, k.Miejscowosc, k.Ulica, k.NrDomu, k.NrLokalu, k.KodPocztowy " +
                " from Klienci as k " +
                " order by k.Nazwisko";

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    Klient klient = new Klient();
                    klient.ID_Klienta = reader.GetInt32(0);
                    klient.Imie = reader.GetString(1);
                    klient.Nazwisko = reader.GetString(2);
                    klient.Email = reader.GetString(3);
                    klient.Miejscowosc = reader.GetString(4);
                    klient.Ulica = reader.GetString(5);
                    klient.NrDomu = reader.GetString(6);
                    klient.NrLokalu = reader.GetString(7);
                    klient.KodPocztowy = reader.GetString(8);
                    listaKlientow.Add(klient);
                }

                reader.Close();
                connection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            return listaKlientow;
        }


        #endregion

        #region Ksiazka
        /// <summary>
        /// Metoda pozwala na zapytania do bazy danych w rodzaju 'SELECT ...' i wyświetla wyniki
        /// w formie tabelki 'DataTable'.
        /// </summary>
        /// <param name="query">zapytanie dane silnikowi baz danych SQLite</param>
        /// <returns>tabelka ze zwróconymi wynikami zapytania</returns>        
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

        /// <summary>
        /// Umożliwia dodanie książki do bazy danych poprzez zapytanie 'INSERT INTO'
        /// </summary>
        /// <param name="ksiazka">dodawna do bazy książka</param>
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

        /// <summary>
        /// Pozwala na usunięcie książki z bazy danych poprzez wewnętrzne zapytanie 'DELETE...'
        /// </summary>
        /// <param name="isbn">isbn (id) książki do usunięcia</param>
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

        /// <summary>
        /// Pozwala na edycję danych książki poprzez użycie wewnętrznie zapytania 'UPDATE...'
        /// </summary>
        /// <param name="isbn">isbn (id) edytowanej książki</param>
        /// <param name="colName">nazwa kolumny, którego atrybut zmieniamy</param>
        /// <param name="newValue">nowa wartość atrybutu książki dla zmienianej kolumny</param>
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

        /// <summary>
        /// Umożliwia wyszukanie w bazie danych książki na podstawie jej id.
        /// </summary>
        /// <param name="Id">id poszukiwanej książki</param>
        /// <returns>książka, której szukamy</returns>
        private Ksiazki pobierzKsiazkePoId(int Id)
        {

            Ksiazki ksi = null;

            try
            {
                SQLiteCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "select k.ISBN, k.Tytul, k.Autor, k.Wydawnictwo, k.RokWydania, k.Gatunek, k.Ilosc, k.Cena  " +
                " from ksiazki as k " +
                " WHERE k.ISBN = " + Id;

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader != null && reader.Read())
                {
                    ksi = new Ksiazki();
                    ksi.ISBN = reader.GetInt32(0);
                    ksi.Tytul = reader.GetString(1);
                    ksi.DaneAutora = reader.GetString(2);
                    ksi.Wydawnictwo = reader.GetString(3);
                    ksi.RokWydania = reader.GetString(4);
                    ksi.Gatunek = reader.GetString(5);
                    ksi.Ilosc = reader.GetInt32(6);
                    try
                    {                        
                        ksi.Cena = Convert.ToDecimal(reader.GetDouble(7));
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Nie załadowano poprawnie ceny hurtowej książki o ISBN " + ksi.ISBN + ". Przyjęto cenę równą 0.", "Nie można odczytać ceny", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ksi.Cena = 0;
                    }

                    reader.Close();
                }

                connection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }

            return ksi;

        }

        /// <summary>
        /// Umożliwia pobranie listy wszystkich książek z bazy danych.
        /// </summary>
        /// <returns>lista wszystkich książek, obecnych w bazie danych</returns>
        internal IList<Ksiazki> pobierzListeKsiazek()
        {

            IList<Ksiazki> listaKsiazek = new List<Ksiazki>();

            try
            {
                SQLiteCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "select k.ISBN, k.Tytul, k.Autor, k.Wydawnictwo, k.RokWydania, k.Gatunek, k.Ilosc, k.Cena  " +
                " from ksiazki as k ";

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    Ksiazki ksi = new Ksiazki();
                    ksi = new Ksiazki();
                    ksi.ISBN = reader.GetInt32(0);
                    ksi.Tytul = reader.GetString(1);
                    ksi.DaneAutora = reader.GetString(2);
                    ksi.Wydawnictwo = reader.GetString(3);
                    ksi.RokWydania = reader.GetString(4);
                    ksi.Gatunek = reader.GetString(5);
                    ksi.Ilosc = reader.GetInt32(6);
                    try
                    {
                        ksi.Cena = reader.GetDecimal(7);
                    }
                    catch
                    {
                        MessageBox.Show("Nie załadowano poprawnie ceny książki o ISBN " + ksi.ISBN + ". Przyjęto cenę równą 0.","Nie można odczytać ceny",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ksi.Cena = 0;
                    }
                    listaKsiazek.Add(ksi);
                }
                reader.Close();
                connection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Błąd bazy danych!\n" + ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }

            return listaKsiazek;

        }

        /// <summary>
        /// Wyszukuje i pobiera z bazy danych listę wszystkich 
        /// faktur wraz ze szczegółami dotyczącymi każdej z faktur.
        /// </summary>
        /// <returns>lista faktur wyszukana w bazie danych</returns>
        internal IList<Faktura> pobierzListeFaktur()
        {
            IList<Faktura> listaFaktur = new List<Faktura>();

            try
            {
                SQLiteCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText =
                "select f.ID_Faktury,  f.Data_Wystawienia, f.ID_Klienta, f.Nr_faktury " +
                " from Faktury as f " +
                " order by f.Data_Wystawienia";

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader != null && reader.Read())
                {

                    Faktura fak = new Faktura();
                    fak.Id = reader.GetInt32(0); ;
                    fak.Data = reader.GetDateTime(1);
                    fak.ID_Klienta = reader.GetInt32(2);
                    fak.Nr = reader.GetInt32(3);

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
                    sprz_ksi.Cena = reader.GetDecimal(4);


                    listaFaktur[licznik].listaSprzedanychKsiazek.Add(sprz_ksi);
                }

                reader.Close();
                connection.Close();
                IList<Ksiazki> listaKsiazek = pobierzListeKsiazek();

                for (int i = 0; i < listaFaktur.Count; i++)
                {
                    for (int j = 0; j < listaFaktur[i].listaSprzedanychKsiazek.Count; j++)
                    {
                        foreach (Ksiazki item in listaKsiazek) //alternatywnie - lepiej tak przypisywać niż pobierać z bazy pojedynczo
                        {
                            if (listaFaktur[i].listaSprzedanychKsiazek[j].IdKsiazki==item.ISBN)
                            {
                                listaFaktur[i].listaSprzedanychKsiazek[j].ksi = item;
                                break;
                            }
                        }
                        //listaFaktur[i].listaSprzedanychKsiazek[j].ksi = pobierzKsiazkePoId(listaFaktur[i].listaSprzedanychKsiazek[j].IdKsiazki);
                    }
                    listaFaktur[i].klient = pobierzKlientaPoId(listaFaktur[i].ID_Klienta);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Błąd bazy danych!\n" + ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            return listaFaktur;
        }

        /// <summary>
        /// Pozwala na usunięcie z bazy danych wszystkich szczegółów odnośnie wybranej faktury.
        /// </summary>
        /// <param name="id_faktury">id faktury, którą chcemy usunąć</param>
        public void UsunFakture(int id_faktury)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "DELETE FROM Faktury WHERE ID_Faktury = '" + id_faktury + "'";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
                myCommand.CommandText = "DELETE FROM Sprzedaz_Ksiazek WHERE ID_Faktury = '" + id_faktury + "'";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        /// <summary>
        /// Pozwala na dodanie do bazy danych pojedynczą fakturę (wraz ze wszystkimi szczegółami).
        /// </summary>
        /// <param name="faktura">dodawana faktura</param>
        public void DodajFakture(Faktura faktura)
        {
            using (connection)
            {
                SQLiteCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "INSERT INTO Faktury(ID_Klienta, ID_Faktury, Data_Wystawienia, Nr_Faktury) VALUES('" + faktura.ID_Klienta + "','" + faktura.Nr + "','" + faktura.Data.ToShortDateString() + "','" + faktura.Nr + "')";
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();

                foreach (SprzedazKsiazek item in faktura.listaSprzedanychKsiazek)
	            {
                    myCommand.CommandText = "INSERT INTO Sprzedaz_Ksiazek(ID_Faktury, ID_Ksiazki, Liczba, Cena) VALUES('" + faktura.Nr + "','" + item.IdKsiazki + "','" + item.Ilosc + "','" + item.CenaString + "')";
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
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

