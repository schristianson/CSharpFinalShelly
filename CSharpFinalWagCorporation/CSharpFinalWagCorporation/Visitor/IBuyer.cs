﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IBuyer             //IVisitable
    {
        void AcceptBuyer(IGadgetBuyer buyer);
    }
}
