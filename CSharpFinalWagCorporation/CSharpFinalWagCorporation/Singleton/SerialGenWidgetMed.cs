using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialGenWidgetMed
    {
        private static volatile SerialGenWidgetMed instance;

        private static object synchronizationRoot = new object();

        private int _count = 2456;

        public static SerialGenWidgetMed Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialGenWidgetMed();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialGenWidgetMed() { }

        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}
