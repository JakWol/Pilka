using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilka
{
    public class Grupa
    {
        private char oznaczenie;
        private string pierwsze_Miejsce;
        private string drugie_Miejsce;

        public char Oznaczenie
        {
            get { return oznaczenie; }
            set { if (value == 'A' || value =='B' || value == 'C'|| value == 'D'||value == 'a' || value == 'b' || value == 'c' || value == 'd')
                {
                    oznaczenie = char.ToUpper(value);
                } else
                {
                    oznaczenie = 'X';
                }
                
            }
        }
        public string Pierwsze_Miejsce
        {
            get { return pierwsze_Miejsce; }
            set { pierwsze_Miejsce = value; }
        }

        public string Drugie_Miejsce
        {
            get { return drugie_Miejsce; }
            set { drugie_Miejsce = value; }
        }

       
    }
}
