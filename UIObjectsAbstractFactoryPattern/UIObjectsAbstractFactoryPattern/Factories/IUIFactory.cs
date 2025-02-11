using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIObjectsAbstractFactoryPattern.Components;

namespace UIObjectsAbstractFactoryPattern.Factories
{
    public interface IUIFactory
    {
        public IButton CreateButton();
        public ITextBox CreateTextBox();
    }
}
