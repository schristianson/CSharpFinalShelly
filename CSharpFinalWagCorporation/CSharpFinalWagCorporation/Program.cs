using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AbstractFactory;
//using Builder;
using CSharpFinalWagCorporation;
using Singleton;
//using Adapter;
//using Decorator;
//using Facade;
//using Iterator;
//using System.Collections;
//using Observer;
using VisitorGadget;                 // add visitor namespace
using VisitorWidget;

namespace CSharpFinalWagCorporation
{
    class Program
    {
        //private static bool widget;

        static void Main(string[] args)
        {
            VisitorPatternG();
            //ObserverPatternDemo();
            //IteratorPatternDemo2();
            //IteratorPatternDemo();
            //FacadePatternDemo();
            //DecoratorPatternDemo();
            //AdapterPatternDemo();
            //SingletonPattern();
            //BuilderPatternDemo();
            //AbstractFactoryDemo();
        }

        //private static void WidgetFactory()
        //{
        // example of using an object of the base:

        //AbstractWidget widget = new SmallWidget();

        //widget.Gears 

        //How to use the BuilderPattern:
        //BikeBuilder builder = new MountainBikeBuilder(mountainBike);
        //BikeDirector director = new MountainBikeDirector();
        //IApplication appl = director.Build(builder);
        //Console.WriteLine(appl);
        //}

        private static void VisitorPatternG()
        {
            IGadget gadget = new SmallGadget(24);
            gadget.SizeGadgetIfChain(1);
            //gadget.AcceptVisitor(new GadgetDiagnostics());
            //gadget.AcceptBuyer(new GadgetInventory(1, 1, "battery"));

            Console.WriteLine(gadget);
            //IWidget widget = new SmallWidget(14);
            //widget.AcceptGetter(new WidgetInventory());
            //Console.WriteLine(widget);
        }

        private static void SingletonPattern()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("Sticker 02SML " + generator.NextSerial);
            Console.WriteLine("Sticker 04MED " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("Sticker 06LRG " + generator.NextSerial);


            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}