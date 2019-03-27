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
            gadget.SizeGadgetIfChain(1, GadgetFinish.Painted);

            Console.WriteLine(gadget);
        }
    }
}