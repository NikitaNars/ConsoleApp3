using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class The_circle
    {
        private double x;
        private double y;
        private double radius;

        public The_circle(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public double LenCircle()
        {
            return 2 * 3.14 * radius;
        }
        public double S()
        {
            return 3.14 * radius * radius;
        }
    }
}
