using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialGenWidgetSmall
    {
        private static volatile SerialGenWidgetSmall instance;

        private static object synchronizationRoot = new object();

        private int _count = 1345;

        public static SerialGenWidgetSmall Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialGenWidgetSmall();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialGenWidgetSmall() { }

        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}
