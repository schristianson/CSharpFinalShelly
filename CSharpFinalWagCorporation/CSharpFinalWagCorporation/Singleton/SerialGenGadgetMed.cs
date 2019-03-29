using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialGenGadgetMed
    {
        private static volatile SerialGenGadgetMed instance;

        private static object synchronizationRoot = new object();

        private int _count = 2355;   //Medium Gadget serial

        public static SerialGenGadgetMed Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialGenGadgetMed();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialGenGadgetMed() { }

        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}
