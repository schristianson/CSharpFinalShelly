using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFinalWagCorporation;

namespace VisitorGadget
{
    public interface IGadgetBuyer
    {
        void Buyer(IGadget gadget);

        void Visit(Switches switches);

        void Visit(Buttons buttons);

        void Visit(PowerSource powersource);

    }
}
