using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorGadget;
using VisitorWidget;

namespace CSharpFinalWagCorporation
{
    public interface IWidget : IBuyer   //Implement an interface within an interface
    {
        int Size { get; }
        bool IsSmall { get; }

        void AcceptGetter(IWidgetGetter getter);
    }
}