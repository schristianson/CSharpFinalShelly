﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFinalWagCorporation;

namespace VisitorGadget
{
    public class GadgetInventory : IGadgetBuyer
    {
        private int _widgetCount;
        private int _switchesCount;
        private int _buttonsCount;
        private int _lightsCount;

        public GadgetInventory(int widgetCount, int switchCount, int buttonsCount, int lightsCount, string powersource)
        {
            _widgetCount = widgetCount;
            _switchesCount = switchCount;
            _buttonsCount = buttonsCount;
            _lightsCount = lightsCount;
            _powersource = powersource;
        }

        public object _powersource { get; private set; }

        public void Buyer(IGadget gadget)
        {
            Console.WriteLine("having: {0} widgets, {1} switches, {2} buttons, {3} lights, and {4} powersource", _widgetCount, _switchesCount, _buttonsCount, _lightsCount, _powersource);
        }

        public void Visit(Widgets widgets)
        {
            _widgetCount++;
        }

        public void Visit(Switches switches)
        {
            _switchesCount++;
        }

        public void Visit(Buttons buttons)
        {
            _buttonsCount++;
        }

        public void Visit(Lights lights)
        {
            _lightsCount++;
        }

        public void Visit(PowerSource powersource)
        {
            Console.WriteLine("powered by a battery");
        }
    }
}
