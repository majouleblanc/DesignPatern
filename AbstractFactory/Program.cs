using AbstractFactory.Contracts;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            var Os = "mac";


            IGuiFactory factory = null;
            if (Os.Equals("win"))
            {
                factory = new WinFactory.WinFactory();
            }
            else if (Os.Equals("mac"))
            {
                factory = new MacFactory.MacFactory();
            }
            else
            {
                throw new Exception("invalid Os");
            }

            var app = new Application(factory);

            app.Run();

            Console.ReadKey();
        }
    }
}
