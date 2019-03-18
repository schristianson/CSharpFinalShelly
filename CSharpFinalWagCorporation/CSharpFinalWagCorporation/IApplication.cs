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
        ISerial GetSerial { get; }

        WidgetFinish ColorType { get; }

        decimal Price { get; }

        void Paint(WidgetFinish finish);

        void CleanFrame();

        void AirTires();

        void TestRide();
    }
}
