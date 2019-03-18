using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalWagCorporation
{
    public abstract class AbstractGadget : IApplication
    {
        private WidgetFinish _color;
        //private IWheel _wheel;

        public WidgetFinish ColorType
        {
            get
            {
                return _color;
            }
        }
        /*
        public IWheel GetWheel
        {
            get
            {
                return _wheel;
            }
        }
        */
        public abstract decimal Price { get; }
        public abstract ISerial GetSerial { get; }

        public AbstractGadget(WidgetFinish finish, ISerial serial)  //public AbstractBike(BikeColor color, IWheel wheel)
        {
            //this._serial = serial;   //this._wheel = wheel;
            //this._finish = finish;   //this._color = color;
        }

        public virtual void Paint(WidgetFinish finish)
        {
            //this._finish = finish;   //this._color = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + " Bicycle Color is " + _color
                + " and cost $" + Price;
        }

        public virtual void CleanFrame()
        {
            Console.WriteLine("Cleaning Frame...");
        }

        public virtual void AirTires()
        {
            Console.WriteLine("Airing tires....");
        }

        public virtual void TestRide()
        {
            Console.WriteLine("Test riding bicycle...");
        }
    }
}
