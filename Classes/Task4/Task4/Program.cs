using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Point
    {
        private int x;
        private int y;
        private string name;

        public Point (int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public int X
        {
            get { return this.x; }
        }

        public int Y
        {
            get { return this.y; }
        }

        public string Name
        {
            get { return this.name; }
        }
    }

    class Figure
    {
       private: Point A,B,C,D,E;

        public Figure (Point A, Point B, Point C) : A(A), B(B), C(C)
        {

        }
        public Figure(Point A, Point B, Point C, Point D) : Figure(A,B,C), D(D)
        {
            
        }
        public Figure(Point A, Point B, Point C, Point D, Point E) : Figure(A,B,C,D), E(E)
        {
            
        }

        double LengthSide (Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        void PerimeterCalculator()
        {
            double sum;
            sum  = LengthSide(A,B) + LengthSide(B,C) + LengthSide(C,D) + LengthSide(D,E) + LengthSide(E,A);
            Console.Write(sum);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
