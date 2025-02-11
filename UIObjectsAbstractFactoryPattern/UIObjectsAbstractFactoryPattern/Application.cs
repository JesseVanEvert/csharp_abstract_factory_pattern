using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIObjectsAbstractFactoryPattern.Factories;

namespace UIObjectsAbstractFactoryPattern
{
    public class Application(IUIFactory factory)
    {
        private readonly IUIFactory _factory = factory;

        public void RenderComponents()
        {
            _factory.CreateButton().Render();
            _factory.CreateTextBox().Render();
        }
    }
}
