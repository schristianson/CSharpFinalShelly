using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace CSharpFinalWagCorporation
{
    public interface IGadget : IBuyer   //Implement an interface within an interface
    {
        int Size { get; }
        bool IsSmall { get; }

        void AcceptBuyer(IGadgetBuyer buyer); //abstractwheel takes in this interface
    }
}
