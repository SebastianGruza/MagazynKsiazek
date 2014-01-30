using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    /// <summary>
    /// Klasa umożliwia przechowywanie wszystkich danych odnośnie klientów naszego magazynu.
    /// </summary>
    public class Klient
    {
        public int ID_Klienta { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string NrLokalu { get; set; }
        public string KodPocztowy { get; set; }

        /// <summary>
        /// Umożliwia stworzenie pojedynczego obiektu klasy Klient na podstawie podstawowych typów.
        /// </summary>
        /// <param name="id_klienta"></param>
        /// <param name="imie"></param>
        /// <param name="nazwisko"></param>
        /// <param name="email"></param>
        /// <param name="miejscowosc"></param>
        /// <param name="ulica"></param>
        /// <param name="nrdomu"></param>
        /// <param name="nrlokalu"></param>
        /// <param name="kodpocztowy"></param>
        public Klient(int id_klienta, string imie, string nazwisko, string email,
            string miejscowosc, string ulica,
            string nrdomu, string nrlokalu, string kodpocztowy)
        {
            ID_Klienta = id_klienta;
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
            Miejscowosc = miejscowosc;
            Ulica = ulica;
            NrDomu = nrdomu;
            NrLokalu = nrlokalu;
            KodPocztowy = kodpocztowy;
        }

        /// <summary>
        /// Pusty konstruktor tworzący pusty obiekt, do dalszej edycji/zastąpienia
        /// </summary>
        public Klient()
        {
            // TODO: Complete member initialization
        }

        public override string ToString()
        {
            return String.Format("{2,-3} {0,-12} {1,-15} ", Imie, Nazwisko, ID_Klienta);
        }

    }
}
