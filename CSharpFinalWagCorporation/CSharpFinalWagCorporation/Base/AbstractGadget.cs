using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace CSharpFinalWagCorporation
{
    public abstract class AbstractGadget : IGadget
    {
        private int _size;
        private bool _isSmall;
        private Switches _switches;
        private Buttons _buttons;
        private PowerSource _powersource;

        public void SizeGadgetIfChain()
        {
            int size = 1;
            Console.WriteLine("Before If");
            if (size == 1)
            {
                Console.WriteLine("Buy Small Gadget");
            }
            else if (size == 2)
            {
                Console.WriteLine("Buy Medium Gadget");
            }
            else if (size == 3)
            {
                Console.WriteLine("Buy Large Gadget");
            }
            else if (size > 3)
            {
                Console.WriteLine("Gadget out of stock");
            }
            else
            {
                Console.WriteLine("Size requested not found");
            }
            Console.WriteLine("After If");
        }




        public int Size
        {
            get
            {
                return _size;

            }
        }
        public bool IsSmall
        {
            get
            {
                return _isSmall;
            }
        }
        public AbstractGadget(int size, bool isSmall)
        {
            this._size = size;
            this._isSmall = isSmall;
            _switches = new Switches();
            _buttons = new Buttons();
            _powersource = new PowerSource();
        }

        public virtual void AcceptBuyer(IGadgetBuyer buyer)
        {
            _switches.AcceptBuyer(buyer);
            _buttons.AcceptBuyer(buyer);
            _powersource.AcceptBuyer(buyer);
            buyer.Buyer(this);
        }

        public override string ToString()
        {
            return this.GetType().Name + " with a gadget size of " + _size + " inches";
        }
    }
}
