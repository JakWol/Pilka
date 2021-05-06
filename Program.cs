using System;

namespace Pilka
{
    class Program
    {
        static void Main(string[] args)
        {

       /*     Zawodnik gracz1 = new Zawodnik("Jerzy", "Dudek", 34, "Polska", false, 0, 2, 1, 1);
            gracz1.pokazZawodnika();
            Sedzia sedzia1 = new Sedzia("Howard", "Webb", 69, "UK", 1, 16, 7, 4);
            sedzia1.pokazSedziego();
            Zawodnik gracz2 = new Zawodnik("Adam", "Małysz", 49, "Polska", false, 1, 3, 4, 2);
            gracz2.pokazZawodnika();
            Zawodnik gracz3 = new Zawodnik("Jezus", "Chytrus", 69, "Polska", false, 1, 3, 4, 2);
            gracz3.pokazZawodnika();*/

            Grupa grupa_smierci = new Grupa();
            grupa_smierci.Pierwsze_Miejsce = "Niemcy";
            grupa_smierci.Drugie_Miejsce = "Polska";
            grupa_smierci.Oznaczenie = 'D';

            Mecz oWszystko = new Mecz();
            oWszystko.Dzien = 24;
            oWszystko.Miesiac = 05;
            oWszystko.Rok = 2017;
            oWszystko.Godzina = 21;
            oWszystko.Minuty = 37;

            Console.WriteLine($"Wielki mecz rozegrał się dnia {oWszystko.Dzien} miesiąca {oWszystko.Miesiac}, w roku pańskim {oWszystko.Rok}, o godzinie {oWszystko.Godzina}:{oWszystko.Minuty}");
            Console.WriteLine();
            Console.WriteLine($"Pierwsze miejsce dla: {grupa_smierci.Pierwsze_Miejsce}");
            Console.WriteLine($"Drugie miejsec dla: {grupa_smierci.Drugie_Miejsce}");
            Console.WriteLine($"Oznaczenie grupy to: {grupa_smierci.Oznaczenie}");

        }
    }

    public class Person
    {

        private string imie;
        private string nazwisko;
        private byte wiek;
        private string kraj;


        public Person()
        {
        }

        public Person (string imie, string nazwisko, byte wiek, string kraj)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.kraj = kraj;

        }
         public virtual void pokazInfo()
        {
            Console.WriteLine($"Imie: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"Wiek: {wiek}");
            Console.WriteLine($"Kraj: {kraj}");
        }
        
    }

    public class Zawodnik : Person
    {
        private bool kapitan;
        private byte pozycja;
        private byte bramki;
        private byte zotle_kartki;
        private byte czerwone_kartki;



        public Zawodnik (string imie, string nazwisko, byte wiek, string kraj, bool kapitan, byte pozycja, byte bramki, byte zotle_kartki, byte czerwone_kartki) :base(imie,nazwisko,wiek,kraj)
        {

            this.kapitan = kapitan;
            this.pozycja = pozycja;
            this.bramki = bramki;
            this.zotle_kartki = zotle_kartki;
            this.czerwone_kartki = czerwone_kartki;
        }

        public void pokazZawodnika()
        {
            base.pokazInfo();

            switch (kapitan)
            {
                case true:
                    Console.WriteLine("Kapitan: tak");
                    break;
                case false:
                    Console.WriteLine("Kapitan: nie");
                    break;
            }
            switch (pozycja)
            {
                case 0:
                    Console.WriteLine("Pozycja: Bramkarz");
                    break;
                case 1:
                    Console.WriteLine("Pozycja: Obrońca");
                    break;
                case 2:
                    Console.WriteLine("Pozycja: Napastnik");
                    break;
                default:
                    Console.WriteLine("Rola nie przydzielona/Błędnie przydzielona, kody wboru mieszczą się w przedziale od 0 do 2");
                    break;
            }
            Console.WriteLine($"Zdobyte bramki: {bramki}");
            Console.WriteLine($"Żółte kartki: {zotle_kartki}");
            Console.WriteLine($"Czerwone kartki {czerwone_kartki}");
        }



    }

    public class Sedzia : Person
    {
        private byte id;
        private byte interwencje;
        private byte kartki;
        private byte ilosc_meczy;

        public Sedzia (string imie, string nazwisko, byte wiek,string kraj, byte id, byte interwencje, byte kartki, byte ilosc_meczy) :base(imie,nazwisko,wiek,kraj)
        {

            this.id = id;
            this.interwencje = interwencje;
            this.kartki = kartki;
            this.ilosc_meczy = ilosc_meczy;
        }

        public void pokazSedziego()
        {
            base.pokazInfo();
            Console.WriteLine($"Id sędziego: {id}");
            Console.WriteLine($"Interwencje: {interwencje}");
            Console.WriteLine($"Wystawione Kartki: {kartki}");
            Console.WriteLine($"Ilość meczy: {ilosc_meczy}");
        }
    }



}
