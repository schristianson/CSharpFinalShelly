﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialGenGadget
    {
        private static volatile SerialGenGadget instance;

        private static object synchronizationRoot = new object();

        private int _count = 1244;

        public static SerialGenGadget Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialGenGadget();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialGenGadget() { }

        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}