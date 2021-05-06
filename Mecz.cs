using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilka
{
    class Mecz
    {
        private static System.DateTime data = new System.DateTime();

        private int rok = data.Year;

        private int miesiac = data.Month;

        private int dzien = data.Day;

        private int godzina = data.Hour;

        private int minuty = data.Minute;

        public int Rok
        {
            get { return rok; }
            set { rok = value;  }
        }
        public int Miesiac
        {
            get { return miesiac; }
            set { miesiac = value; }
        }
        public int Dzien
        {
            get { return dzien; }
            set { dzien = value; }
        }
        public int Godzina
        {
            get { return godzina; }
            set { godzina = value; }
        }
        public int Minuty
        {
            get { return minuty; }
            set { minuty = value; }
        }




    }
}
