using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Application
    {
        private readonly IGuiFactory _factory;


        public Application(IGuiFactory factory)
        {
            _factory = factory;
        }

        public void Run()
        {
            var button = _factory.CreateButton();
            button.paint();
            Console.WriteLine();

            var checkbox = _factory.CreateButton();
            checkbox.paint();
            Console.WriteLine();
        }
    }
}
