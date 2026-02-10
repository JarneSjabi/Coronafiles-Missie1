using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaFiles_1
{
    class SlimVaccin: Vaccin
    {
        public SlimVaccin(string naamin) : base(naamin)
        {

        }

        // Het Vaccin zal eerst alle veelvouden van 10 (0,10, 20, etc.) testen. Vervolgens 11,21,31,...en dan 12,22, etc.
        int next = 0;
        public override int TryKillCode()
        {
            int tosend = next;
            next = next + 10;

            if (next > 100)
            {
                int r = next % 10;
                next = r + 1;
            }

            return tosend;
        }
    }
}
