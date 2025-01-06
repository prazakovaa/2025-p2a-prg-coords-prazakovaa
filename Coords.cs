using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coords {
    
    public class Coord: IEquatable<Coord>, IComparable<Coord>
    {
        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public double Size { get { return Math.Sqrt(X * X + Y * Y); } }
        public double Magnitude { get { return (X * X + Y * Y); } }

        public bool Equals(Coord? souradnice)
        { return this.Size == souradnice.Size; }

        public static bool operator == (Coord? s1, Coord? s2)
        { return s1.Equals(s2); }

        public static bool operator != (Coord? s1, Coord? s2)
        { return !(s1.Equals(s2)); }

        public int CompareTo(Coord souradnice)
        {
            return this.Size.CompareTo(souradnice.Size);
        }

        public static int operator < (Coord? s1, Coord? s2)
        { return s1.CompareTo(s2); }

        public static int operator > (Coord? s1, Coord? s2)
        { return s2.CompareTo(s1); }

    }

}

