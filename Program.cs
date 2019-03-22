using System;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, I have installed Git");
            Console.WriteLine("I'm making these experimental changes");
            Student c = new Student();
            c.Name = "Joe Smith";
            c.Id = 4;
            Console.WriteLine(c.Name);
        }
    }
}
