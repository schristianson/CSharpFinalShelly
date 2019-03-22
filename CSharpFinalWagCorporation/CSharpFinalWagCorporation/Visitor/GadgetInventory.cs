using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFinalWagCorporation;

namespace Visitor
{
    public class GadgetInventory : IGadgetBuyer
    {
        private int _switchesCount;
        private int _buttonsCount;

        public GadgetInventory()
        {
            _switchesCount = 1;
            _buttonsCount = 1;
        }


        public void Buyer(IGadget gadget)
        {
            Console.WriteLine("The gadget has: {0} switches and {1} buttons", _switchesCount, _buttonsCount);
        }

        public void Visit(Switches switches)
        {
            _switchesCount++;
        }

        public void Visit(Buttons buttons)
        {
            _buttonsCount++;
        }
    }
}
