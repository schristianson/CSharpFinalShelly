using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorGadget;
using VisitorWidget;

namespace CSharpFinalWagCorporation
{
    public abstract class AbstractWidget : IWidget
    {
        private int _size;
        private bool _isSmall;
        private Gears _gears;
        private Springs _springs;
        private Levers _levers;

        public int Size
        {
            get
            {
                return _size;

            }
        }
        public bool IsSmall
        {
            get
            {
                return _isSmall;
            }
        }

        public void AcceptBuyer(IGadgetBuyer buyer)
        {

        }

        public AbstractWidget(int size, bool isSmall)
        {
            this._size = size;
            this._isSmall = isSmall;
            _gears = new Gears();
            _springs = new Springs();
            _levers = new Levers();
        }

        public virtual void AcceptGetter(IWidgetGetter getter)
        {
            _gears.AcceptGetter(getter);
            _springs.AcceptGetter(getter);
            _levers.AcceptGetter(getter);
            getter.Getter(this);
        }

        public override string ToString()
        {
            return this.GetType().Name + " with a widget size of " + _size + " inches";
        }
    }
}
