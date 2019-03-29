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
        private Lights _lights;
        private PowerSource _powersource;

        public void SizeGadgetIfChain(int size, GadgetFinish finish, WidgetFinish finishw)

        {
            if (size == 1)
            {
                SerialGenGadgetSmall generator = SerialGenGadgetSmall.Instance;

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Buy the Lowest priced ");
                Console.WriteLine("small gadget ====> ");
                AcceptBuyer(new GadgetInventory(2, 1, 2, 0, "battery"));
                Console.WriteLine("This gadget is gold " + finish);
                Console.WriteLine("Serial# Sticker 02SML " + generator.NextSerial);

                IWidget widget = new SmallWidget(14);
                widget.AcceptGetter(new WidgetInventory());
                SerialGenWidgetSmall gensmlw = SerialGenWidgetSmall.Instance;
                Console.WriteLine("Serial# Sticker 22SML " + gensmlw.NextSerial);
                Console.WriteLine(widget);
                Console.WriteLine(finishw);
            }
            else if (size == 2)
            {
                SerialGenGadgetMed generator = SerialGenGadgetMed.Instance;

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Buy the Medium priced ");
                Console.WriteLine("medium gadget ====> ");
                AcceptBuyer(new GadgetInventory(5, 1, 2, 3, "solar"));
                Console.WriteLine("This gadget is silver " + finish);
                Console.WriteLine("Serial# Sticker 04MED " + generator.NextSerial);

                IWidget widget = new MediumWidget(15);
                widget.AcceptGetter(new WidgetInventory());
                SerialGenWidgetMed genmedw = SerialGenWidgetMed.Instance;
                Console.WriteLine("Serial# Sticker 44MED " + genmedw.NextSerial);
                Console.WriteLine(widget);
                Console.WriteLine(finishw);

            }
            else if (size == 3)
            {
                SerialGenGadgetLrg generator = SerialGenGadgetLrg.Instance;

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Buy the Large priced ");
                Console.WriteLine("large gadget ====> ");
                AcceptBuyer(new GadgetInventory(12, 2, 4, 5, "generator"));
                Console.WriteLine("This gadget is platinum " + finish);
                Console.WriteLine("Serial# Sticker 06LRG " + generator.NextSerial);

                IWidget widget = new LargeWidget(16);
                widget.AcceptGetter(new WidgetInventory());
                SerialGenWidgetLrg genlrgw = SerialGenWidgetLrg.Instance;
                Console.WriteLine("Serial# Sticker 66LRG " + genlrgw.NextSerial);
                Console.WriteLine(widget);
                Console.WriteLine(finishw);

            }
            else if (size > 3)
            {
                Console.WriteLine("Gadget out of stock");
            }
            else
            {
                Console.WriteLine("Size requested not found");
            }
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
            return "";
            //return this.GetType().Name + " with a gadget size of " + _size + " inches";
        }
    }
}
