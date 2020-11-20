using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Application
    {
        private readonly IGuiFactory _factory;
        private IButton _button;
        private ICheckbox _checkbox;

        public Application(IGuiFactory factory)
        {
            _factory = factory;
        }

        public void CreateUI()
        {
            _button = _factory.CreateButton();
            _checkbox = _factory.CreateCheckbox();
        }

        public void Run()
        {
            CreateUI();

            _button.paint();
            Console.WriteLine();

            _checkbox.paint();
            Console.WriteLine();
        }
    }
}
