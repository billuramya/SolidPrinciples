using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples
{
    // a class should not forced to implement the Interfaces if doesn't use.
    interface Iwork
    {
        void Work();
        
    }
    interface IBreakable
    {
        void TakeBreak();
    }
    class manager : Iwork, IBreakable
    {
        public void TakeBreak() {
            Console.WriteLine("I want Leave");
        }
        public void Work()
        {
            Console.WriteLine("Next Week I work Extra Two Days");
        }
    }
}
