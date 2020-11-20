using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.MacCheckbox
{
    class MacCheckbox : ICheckbox
    {
        public void paint()
        {
            Console.WriteLine("paintMacCheckbox");
        }
    }
}
