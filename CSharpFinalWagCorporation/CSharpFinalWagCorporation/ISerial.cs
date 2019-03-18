using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalWagCorporation
{
    public interface ISerial
    {
        int Size { get; }
        bool IsWide { get; }

        //void AcceptVisitor(IWheelVisitor visitor); //abstractwheel takes in this interface
    }
}
