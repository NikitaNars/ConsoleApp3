using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Triangle
    {
        private double len1;
        private double len2;
        private double len3;

        public Triangle(double len1, double len2, double len3)
        {
            this.len1 = len1;
            this.len2 = len2;
            this.len3 = len3;
        }

        public double P()
        {
            return len1 + len2 + len3;

        }
        public void PrintP()
        {
            Console.WriteLine(this.P());
        }
        public void PrintSide()
        {
            Console.WriteLine("Сторона 1 = " + len1);
            Console.WriteLine("Сторона 2 = " + len2);
            Console.WriteLine("Сторона 3 = " + len3);
        }

    }
}
