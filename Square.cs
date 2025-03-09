using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Square
    {
        private double x;
        private double y;
        private double lenSide;
        public Square(double x, double y, double lenSide )
        {
            this.x = x;
            this.y = y;
            this.lenSide = lenSide;
        }
        public double P()
        {
            return lenSide * 4;
        }
        public double S()
        {
            return lenSide * 2;
        }
    }
}
