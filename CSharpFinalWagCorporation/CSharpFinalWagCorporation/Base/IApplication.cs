using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalWagCorporation
{
    public interface IApplication
    {
        //IWheel GetWheel { get; }
        IGadget GetGadget { get; }

        GadgetFinish FinishType { get; }

        decimal Price { get; }

        void Paint(GadgetFinish finish);

        //void CleanFrame();

        //void AirTires();

        //void TestRide();
    }
}
