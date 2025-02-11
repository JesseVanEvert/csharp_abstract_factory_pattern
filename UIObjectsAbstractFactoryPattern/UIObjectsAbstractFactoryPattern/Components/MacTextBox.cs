using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIObjectsAbstractFactoryPattern.Components
{
    public class MacTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("A text box for OSX");
        }
    }
}
