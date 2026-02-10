using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaFiles_1
{
    class DomVirus : Virus
    {
        static Random r = new Random();
        public override bool TryVaccin(Vaccin vacin)
        {
            bool result = base.TryVaccin(vacin);
            if (r.Next(0, 2) == 0)
            {
                DoomCountDown += 2;
            }
            return result;
        }
    }
}
