using System;
using System.Collections.Generic;
using System.Text;
using CoronaFiles_1.CoronaFiles_1;

namespace CoronaFiles_1
{
    class StadsEnclave : Enclave
    {
        private Waterkrachtcentrale waterkrachtcentrale;
        private Hospitaal extrahospitaal;
        private List<Flat> flats = new List<Flat>();

        public override void BouwWoonst()
        {
            base.BouwWoonst();
            if (woningen.Count % 3 == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    woningen.RemoveAt(0);
                }
                flats.Add(new Flat("woonst", r.Next(1, Console.WindowWidth), r.Next(1, Console.WindowHeight)));
            }
        }
        public override void ToonEclave()
        {
            base.ToonEclave();

            extrahospitaal?.PrintGebouw();
            waterkrachtcentrale?.PrintGebouw();
            foreach (var flat in flats)
            {
                flat.PrintGebouw();
            }

        }
    }
}
