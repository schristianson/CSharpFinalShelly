using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGenerator
    {
        /*
         * private - Access modifier that restricts access to the class only.
         * static - no instances of this variable are created. It is only 1.
         * volatile - may be modified by multiple threads that are executing at 
         * the same time.
         */
        private static volatile SerialNumberGenerator instance;

        /* 
         * object - root of all objects in .Net 
         */
        private static object synchronizationRoot = new object();

        private int _count = 1244;

        /*
         * property of the class SerialNumberGenerator that is read-only
         * */
        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialNumberGenerator() { }

        public int NextSerial
        {
            get { return ++_count; }
        }

    }
}
