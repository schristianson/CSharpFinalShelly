﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorWidget;

namespace VisitorGadget
{
    public interface IBuyer             //IVisitable
    {
        void AcceptBuyer(IGadgetBuyer buyer);
    }
}