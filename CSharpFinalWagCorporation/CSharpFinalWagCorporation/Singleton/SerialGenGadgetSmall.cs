using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialGenGadgetSmall
    {
        private static volatile SerialGenGadgetSmall instance;

        private static object synchronizationRoot = new object();

        private int _count = 1244;  //Small Gadget serial
        //private int _count = 2355;   //Medium Gadget serial
        //private int _count = 3466;   //Large Gadget serial

        public static SerialGenGadgetSmall Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialGenGadgetSmall();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialGenGadgetSmall() { }

        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}
