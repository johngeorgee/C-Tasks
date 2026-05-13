using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Tasks
{
    internal class _3DPoint
    {
        public double X;
        public double Y;
        public double Z;
        public _3DPoint(double x, double y, double z) 
        {
            X = x;
            Y = y;
            Z = z;
        }
        public _3DPoint(double x, double y) : this(x, y , 2.5)
        {
   
        }
        public _3DPoint(double x) : this(x,2.5)
        {
          
        }
        public _3DPoint() : this(6.3)
        {
      

        }
        public static bool operator==(_3DPoint p1, _3DPoint p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }
        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            return !(p1 == p2);
        }
        public void ChangeCoordinates(double newX, double newY, double newZ)
        {
            X = newX;
            Y = newY;
            Z = newZ;
        }
        public void DisplayCoordinates()
        {
            Console.WriteLine($"Coordinates: ({X}, {Y}, {Z})");
        }
        public override bool Equals(object? obj)
        {
            if (obj is _3DPoint other)
            {
                return this == other;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }
        public override string ToString()
        {
            return $"{X} , {Y} , {Z}";
            ;
        }
        public void Display(_3DPoint[] points)
        {
            foreach(var point in points)
            {
                Console.WriteLine($"Coordinates: ({point.X}, {point.Y}, {point.Z})");
            }
        }
    }
}