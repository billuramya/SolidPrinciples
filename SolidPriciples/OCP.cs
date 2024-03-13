using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples
{
    //open for extention and close for Modification 
    interface AreaOfOblect
    {
        double Area();
    }
    class Circle : AreaOfOblect
    {
        public double Radius { get; set; }

       public double Area()
        { 
            return Math.PI * Math.Pow(Radius,2); 
        }

    }
    class Squeare : AreaOfOblect
    {
        public double Side { get; set; }
        public double Area()
        {
            return Math.Pow(Side,2);
        }
    }
}
