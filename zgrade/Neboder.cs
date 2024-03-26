using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zgrade
{
    internal class Neboder
    {
        int visina = 3, brojKatova;

        public int Visina { get => visina; set => visina = value; }
        public int BrojKatova { get => brojKatova; set => brojKatova = value; }
        
        public int Izracunajvisinu(int Brojkatova1)
        {
            Visina = BrojKatova * Visina;
            return visina;
        }
    }
}
