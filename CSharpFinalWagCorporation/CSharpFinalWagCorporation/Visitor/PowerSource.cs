using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFinalWagCorporation;

namespace Visitor
{
    public class PowerSource : IBuyer
    {
        public void AcceptBuyer(IGadgetBuyer buyer)
        {
            //buyer.Buyer(this);
        }
    }
}
