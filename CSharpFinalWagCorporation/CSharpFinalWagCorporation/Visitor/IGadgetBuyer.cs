using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFinalWagCorporation;

namespace Visitor
{
    public interface IGadgetBuyer
    {
        void Visit(IGadget gadget);

        //void Visit(Spokes spokes);

        //void Visit(Bearings bearings);

    }
}
