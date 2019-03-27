using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWidget
{
    public interface IGetter             //IVisitable
    {
        void AcceptGetter(IWidgetGetter getter);
    }
}
