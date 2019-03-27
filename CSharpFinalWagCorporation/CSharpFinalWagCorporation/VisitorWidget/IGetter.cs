using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWidget
{
    public interface IGetter
    {
        void AcceptGetter(IWidgetGetter getter);
    }
}
