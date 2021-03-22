using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterBeer rb = new RegisterBeer("Momento","AC");
            Beer cerveza = rb.MapToBeer();
            Console.WriteLine(cerveza.Brand + " " + cerveza.Name);
            Console.ReadKey();
        }
    }
}
