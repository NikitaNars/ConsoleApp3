using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Rectangle
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;

        public Rectangle(double x1, double y1, double x2, double y2) 
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;

        }
        public double P()
        {
            return (x2 - x1) * 2 + (y1 - y2) * 2;
        }
        public double S()
        {
            return (x2 - x1) * (y1 - y2);
        }
    }
}
