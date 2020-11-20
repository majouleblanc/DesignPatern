using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.WinButton
{
    class WinButton : IButton
    {
        public void paint()
        {
            Console.WriteLine("paintWinButton");
        }
    }
}
