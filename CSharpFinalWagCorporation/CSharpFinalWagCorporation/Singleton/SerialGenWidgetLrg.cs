using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialGenWidgetLrg
    {
        private static volatile SerialGenWidgetLrg instance;

        private static object synchronizationRoot = new object();

        private int _count = 3567;   //Serial large

        public static SerialGenWidgetLrg Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialGenWidgetLrg();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialGenWidgetLrg() { }

        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}
