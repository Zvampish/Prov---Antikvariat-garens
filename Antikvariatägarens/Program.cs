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
            //Testar GetName och GetCategory
            Console.WriteLine("\nAs previously stated the name of the book is " + newBook.GetName() +
            " and the category is " + newBook.GetCategory() + ".");

            Console.ReadLine();
        }
    }
}
