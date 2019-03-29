using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFinalWagCorporation;
using Singleton;
using VisitorGadget;
using VisitorWidget;

namespace CSharpFinalWagCorporation
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitorPatternG();
        }


        private static void VisitorPatternG()
        {
            IGadget gadget = new SmallGadget(24);

            //Small Gadget Size=1:
            gadget.SizeGadgetIfChain(1, GadgetFinish.Painted, WidgetFinish.Plain);

            //Medium Gadget Size=2:
            gadget.SizeGadgetIfChain(2, GadgetFinish.Plated, WidgetFinish.Plain);

            //Large Gadget Size=3:
            gadget.SizeGadgetIfChain(3, GadgetFinish.Plated, WidgetFinish.Plain);

            Console.WriteLine(gadget);
        }
    }
}