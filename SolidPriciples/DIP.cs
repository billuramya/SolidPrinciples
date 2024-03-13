using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples
{
     interface ISwitchable 
    {
        void TurnOn();
        void TurnOff();
    }
    interface LightBlub: ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Lights Will Turned On");
        }
        public void TurnOff()
        {
            Console.WriteLine("Light will Turned Off");
        }
    }
    class Switch
    {
        private ISwitchable device;
        public Switch(ISwitchable device)
        {
            this.device = device;
        }
        public void Operate()
        {
            device.TurnOn();
        }
    }
}
