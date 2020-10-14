using System;

namespace Antikvariatägarens
{
    public class Customer
    {
        string name;

        Customer()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
    }
}
