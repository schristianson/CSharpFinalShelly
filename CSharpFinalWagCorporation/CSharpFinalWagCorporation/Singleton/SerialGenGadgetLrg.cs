using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialGenGadgetLrg
    {
        private static volatile SerialGenGadgetLrg instance;

        private static object synchronizationRoot = new object();

        private int _count = 3466;  //Large Gadget serial

        public static SerialGenGadgetLrg Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialGenGadgetLrg();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialGenGadgetLrg() { }

        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}
