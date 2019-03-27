using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorGadget;
using VisitorWidget;

namespace CSharpFinalWagCorporation
{
    public abstract class AbstractGadget : IGadget
    {
        private int _size;
        private bool _isSmall;
        private Switches _switches;
        private Buttons _buttons;
        private PowerSource _powersource;

        public void SizeGadgetIfChain(int size, GadgetFinish finish)
        {
            //int size = 1;
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;
            Console.WriteLine("Buy the Lowest priced ");
            if (size == 1)
            {
                Console.WriteLine("small gadget ====> ");
                AcceptBuyer(new GadgetInventory(2, 1, 2, "battery"));
                Console.WriteLine("This gadget is gold " + finish);

                IWidget widget = new SmallWidget(14);
                widget.AcceptGetter(new WidgetInventory());
                Console.WriteLine("Sticker 02SML " + generator.NextSerial);
                Console.WriteLine(widget);
            }
            else if (size == 2)
            {
                Console.WriteLine("Buy Medium Gadget");
                AcceptBuyer(new GadgetInventory(5, 1, 2, "solar"));

                IWidget widget = new MediumWidget(14);
                widget.AcceptGetter(new WidgetInventory());
                Console.WriteLine("Sticker 04MED " + generator.NextSerial);
                Console.WriteLine(widget);
            }
            else if (size == 3)
            {
                Console.WriteLine("Buy Large Gadget");
                AcceptBuyer(new GadgetInventory(12, 2, 4, "generator"));

                IWidget widget = new LargeWidget(14);
                widget.AcceptGetter(new WidgetInventory());
                Console.WriteLine("Sticker 06LRG " + generator.NextSerial);
                Console.WriteLine(widget);
            }
            else if (size > 3)
            {
                Console.WriteLine("Gadget out of stock");
            }
            else
            {
                Console.WriteLine("Size requested not found");
            }
            //Console.WriteLine("After If");
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
