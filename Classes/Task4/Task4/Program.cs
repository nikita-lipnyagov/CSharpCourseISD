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
       
        public Figure (Point A, Point B, Point C)
        {
            
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            
        }

        double LengthSide (Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        void PerimeterCalculator()
        {
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
