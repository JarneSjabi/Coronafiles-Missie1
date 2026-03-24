using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaFiles_1
{
    abstract class Gebouw
    {
        public Gebouw(string naamin, int xin, int yin)
        {
            Naam = naamin;
            X = xin;
            Y = yin;
        }
        public string Naam { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public abstract void PrintGebouw();

        public override string ToString()
        {
            return $"{Naam} (locatie: {X},{Y})";
        }
    }
}
