using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaFiles_1
{
    class Waterkrachtcentrale: Gebouw
    {
        const char c = 'G';
        public Waterkrachtcentrale(string naamin, int xin, int yin) : base(naamin, xin, yin)
        {
            
        }

        public override string ToString()
        {
            base.ToString();
            return $"{Naam} (locatie: {X},{Y})";
        }

        public override void PrintGebouw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(c);
        }
    }
}
