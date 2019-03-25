using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalWagCorporation
{
    public class SmallWidget : AbstractWidget
    {
        //auto properties with default values, strings or integers
        public override string Gears { get; } = "2 Gears";
    }
}
