using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIObjectsAbstractFactoryPattern.Components
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("A button for OSX systems");
        }
    }
}
