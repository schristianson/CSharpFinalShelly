using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AbstractFactory;
//using Builder;
using Singleton;
//using Adapter;
//using Decorator;
//using Facade;
//using Iterator;
//using System.Collections;
//using Observer;
//using Visitor;                 // add visitor namespace

namespace CSharpFinalWagCorporation
{
    class Program
    {
        static void Main(string[] args)
        {
            //VisitorPatternDemo();
            //ObserverPatternDemo();
            //IteratorPatternDemo2();
            //IteratorPatternDemo();
            //FacadePatternDemo();
            //DecoratorPatternDemo();
            //AdapterPatternDemo();
            SingletonPatternDemo();
            //BuilderPatternDemo();
            //AbstractFactoryDemo();
        }

        private static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("02SML " + generator.NextSerial);
            Console.WriteLine("04MED " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("06LRG " + generator.NextSerial);

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

        }
    }
}
