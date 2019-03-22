using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Switches : IBuyer
    {
        public void AcceptBuyer(IGadgetBuyer buyer)
        {
            //buyer.Buyer(this);
        }
    }
}
