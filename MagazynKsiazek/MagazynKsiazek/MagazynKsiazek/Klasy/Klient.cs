using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    class Klient
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

        public Klient()
        {
            // TODO: Complete member initialization
        }

    }
}
