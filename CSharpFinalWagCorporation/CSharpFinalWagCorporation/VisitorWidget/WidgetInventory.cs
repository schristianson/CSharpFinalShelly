using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFinalWagCorporation;
using VisitorWidget;

namespace VisitorWidget
{
    public class WidgetInventory : IWidgetGetter
    {
        private int _gearsCount;
        private int _springsCount;
        private int _leversCount;

        public WidgetInventory()
        {
            _gearsCount = 2;
            _springsCount = 3;
            _leversCount = 1;
        }

        public object _powersource { get; private set; }

        public void Getter(IWidget widget)
        {
            Console.WriteLine("The Small Widget has: {0} gears and {1} springs and {2} levers", _gearsCount, _springsCount, _leversCount);
        }

        public void Visit(Gears gears)
        {
            _gearsCount++;
        }

        public void Visit(Springs springs)
        {
            _springsCount++;
        }

        public void Visit(Levers levers)
        {
            _leversCount++;
        }
    }
}
