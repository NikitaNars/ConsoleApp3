using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Rectangle
    {
        private double sideLength1;
        private double sideLength2;
        private double sideWidth1;
        private double sideWidth2;

        public Rectangle(double sideLength1, double sideLength2, double sideWidth1, double sideWidth2) 
        {
            this.sideLength1 = sideLength1;
            this.sideLength2 = sideLength2;
            this.sideWidth1 = sideWidth1;
            this.sideWidth2 = sideWidth2;
        }
        public double P()
        {
            return sideLength1 + sideLength2 + sideWidth1 + sideWidth2;
        }
        public double S()
        {
            return sideLength1 * sideWidth1;
        }
    }
}
