using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.MacButton
{
    class MacButton : IButton
    {
        public void paint()
        {
            Console.WriteLine("paintMacButton");
        }
    }
}
