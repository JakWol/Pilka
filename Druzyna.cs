using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilka
{
    class Druzyna
    {
        private string kraj;
        private short liczba_Punktow;
        private short kontuzje;
        private short rozegrane_Mecze;
        private int zdobyte_Gole;
        private int utracone_bramki;

        public string Kraj
        {
            get { return kraj; }
            set { kraj = value; }
        }
        public short Liczba_Punktow
        {
            get { return liczba_Punktow; }
            set { liczba_Punktow = value; }
        }
        public short Kontuzje
        {
            get { return kontuzje; }
            set { kontuzje = value; }
        }
        public short Rozegrane_Mecze
        {
            get { return rozegrane_Mecze; }
            set { rozegrane_Mecze = value; }
        }
        public int Zdobyte_Gole
        {
            get { return zdobyte_Gole; }
            set { zdobyte_Gole= value; }
        }
        public int Utracone_Bramki
        {
            get { return utracone_bramki; }
            set { utracone_bramki = value; }
        }


    }
}
