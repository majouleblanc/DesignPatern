using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Contracts
{
    public interface IGuiFactory
    {
        public IButton CreateButton();
        public ICheckbox CreateCheckbox();
    }
}
