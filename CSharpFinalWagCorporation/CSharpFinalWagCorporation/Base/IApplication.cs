using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalWagCorporation
{
    public interface IApplication
    {
        IGadget GetGadget { get; }

        GadgetFinish FinishType { get; }

        decimal Price { get; }

        void Paint(GadgetFinish finish);

        void PowerSource();

        //void AirTires();

        //void TestRide();
    }
}
