using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIObjectsAbstractFactoryPattern.Components;

namespace UIObjectsAbstractFactoryPattern.Factories
{
    public class MacFactory : IUIFactory
    {
        private static MacFactory? _instance = null;
        private MacFactory()
        {
            
        }

        public static MacFactory GetInstance()
        {
            _instance ??= new MacFactory();
            return _instance;
        }
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
