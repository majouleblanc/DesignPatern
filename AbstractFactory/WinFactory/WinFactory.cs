using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.WinFactory
{
    class WinFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            Console.WriteLine("winButton Created\n");
            return new WinButton.WinButton();
        }

        public ICheckbox CreateCheckbox()
        {
            Console.WriteLine("winCheckbox Created\n");
            return new WinCheckbox.WinCheckbox();
        }
    }
}
