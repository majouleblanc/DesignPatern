using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.WinCheckbox
{
    class WinCheckbox : ICheckbox
    {
        public void paint()
        {
            Console.WriteLine("paintWinCheckbox");
        }
    }
}
