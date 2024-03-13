using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples
{
    interface FlyBird
    {
        void Fly();
    }
    
    class Bird : FlyBird
    {
        public void Fly()
        {
            Console.WriteLine("I Want To Fly");
        }

    }
    class Penguin :FlyBird
    {
        public void Fly() {
            Console.WriteLine("I Don't want to fly");
        }
    }
}
