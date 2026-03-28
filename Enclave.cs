using CoronaFiles_1.CoronaFiles_1;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace CoronaFiles_1
{
    class Enclave
    {
        protected static Random r = new Random();

        private Hospitaal hospitaal;
        private Generator generator;
        protected List<Woonst> woningen = new List<Woonst>();

        public Enclave()
        {
            hospitaal = new Hospitaal("starthospitaal", r.Next(1, Console.WindowWidth), r.Next(1, Console.WindowHeight));
            generator = new Generator("generator1", r.Next(1, Console.WindowWidth), r.Next(1, Console.WindowHeight));
            for (int i = 0; i < 3; i++)
            {
                woningen.Add(new Woonst("woonst", r.Next(1, Console.WindowWidth), r.Next(1, Console.WindowHeight)));
            }

        }

        public virtual void BouwWoonst()
        {
            int xpoging = 0;
            int ypoging = 0;
            do
            {
                xpoging = r.Next(1, Console.WindowWidth);
                ypoging = r.Next(1, Console.WindowHeight);

            } while (!IsLeeg(xpoging, ypoging));

            woningen.Add(new Woonst("woonst", xpoging, ypoging));
        }


        public virtual void ToonEclave()
        {
            generator?.PrintGebouw();
            hospitaal?.PrintGebouw();
            foreach (var woonst in woningen)
            {
                woonst.PrintGebouw();
            }
        }

        private bool IsLeeg(int x, int y)
        {


            if (hospitaal.X == x && hospitaal.Y == y)
                return false;
            if (generator.X == x && generator.Y == y)
                return false;
            foreach (var huisje in woningen)
            {
                if (huisje.X == x && huisje.Y == y)
                    return false;
            }

            return true;
        }
    }
}
