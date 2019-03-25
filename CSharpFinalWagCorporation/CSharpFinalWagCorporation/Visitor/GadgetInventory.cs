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
            _buttonsCount = 2;
            _powersource = "battery";
        }

        public object _powersource { get; private set; }

        public void Buyer(IGadget gadget)
        {
            Console.WriteLine("The Small Gadget has: {0} switches and {1} buttons and {2} powersource", _switchesCount, _buttonsCount, _powersource);
        }

        public void Visit(Switches switches)
        {
            _switchesCount++;
        }

        public void Visit(Buttons buttons)
        {
            _buttonsCount++;
        }

        public void Visit(PowerSource powersource)
        {
            Console.WriteLine("powered by a battery");
        }
    }
}
