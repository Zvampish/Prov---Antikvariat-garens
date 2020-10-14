using System;

namespace Antikvariatägarens
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book();

            newBook.PrintInfo();

            newBook.Evaluate();

            Console.ReadLine();
        }
    }
}
