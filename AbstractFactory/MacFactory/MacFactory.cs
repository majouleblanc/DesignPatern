using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.MacFactory
{
    class MacFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            Console.WriteLine("MacButton Created\n");
            return new MacButton.MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            Console.WriteLine("MacCheckBox Created\n");
            return new MacCheckbox.MacCheckbox();
        }
    }
}
