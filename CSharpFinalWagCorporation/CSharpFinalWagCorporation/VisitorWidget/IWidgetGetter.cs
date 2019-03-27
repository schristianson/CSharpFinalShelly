using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFinalWagCorporation;

namespace VisitorWidget
{
    public interface IWidgetGetter
    {
        void Getter(IWidget widget);

        void Visit(Gears gears);

        void Visit(Springs springs);

        void Visit(Levers levers);

    }
}
