using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIObjectsAbstractFactoryPattern.Components;

namespace UIObjectsAbstractFactoryPattern.Factories
{
    public class WindowsFactory : IUIFactory
    {
        private static WindowsFactory _instance = null;

        private WindowsFactory()
        {
            
        }

        public static WindowsFactory GetInstance()
        {
            _instance ??= new WindowsFactory();
            return _instance;
        }
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
