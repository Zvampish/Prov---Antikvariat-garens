using System;
using System.Collections.Generic;

namespace Antikvariatägarens
{
    public class Book
    {
        public int price;
        string name;
        int rarity;
        string category;
        int actualValue;
        bool cursed;
        
        static Random generator = new Random();

        public Book()
        {
            //Jag bregränsade actualValue till $10 eftersom det är ett rimligt pris för en bok 
            actualValue = generator.Next(1, 11);
            //Begränsade även rarity så att man kan namnge de tre olika rarities till t.ex common, ucommon och epic.
            rarity = generator.Next(1, 4);

            int cursedInt = generator.Next(0, 2);
            
            if(cursedInt == 0)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }
            
            List<string> bookNames = new List<string>() {"Harry Potter", "The Lord of the Rings", "Star Wars"};
            List<string> bookCategories = new List<string>() {"Fantasy", "historical fiction", "science fiction"};
            //Slumpa ett namn och en kategori!!!

            int bookNameNr = generator.Next(0, 3);
            int bookCategoryNr = generator.Next(0, 3);   

            if(bookNameNr == 0)
            {
                name = bookNames[0];
            }
            else if(bookNameNr == 1)
            {
                name = bookNames[1];
            }
            else if(bookNameNr == 2)
            {
                name = bookNames[2];
            }

            if(bookCategoryNr == 0)
            {
                category = bookCategories[0];
            }
            else if(bookCategoryNr == 1)
            {
                category = bookCategories[1];
            }
            else if(bookCategoryNr == 2)
            {
                category = bookCategories[2];
            }
        }
        //Nedan skriver PrintInfo() ut namnet på boken, kategorin, sällsyntheten och det faktiska värdet.
        public void PrintInfo()
        {
            Console.WriteLine("The book is named " + name + "." +
            "\nThe category is " + category + "." +
            "\nThe rarity of the book is " + rarity + ". (The higher rarity, the better! The greatest rarity is 3, whist the lowest is 1)" +
            "\nThe book costs $" + actualValue + ".");
            
        }
        public void Evaluate()
        {
            //Vet inte hur jag ska lägga till det som står i nästa kommentar så jag skippar det.
            //"Sedan slumpas värdet som ska returneras mellan 50% och 150% av "rätt pris"."
            price = actualValue *= rarity;
        }
        public string GetCategory()
        {
            return category;
        }
        public string GetName()
        {
            return name;
        }
        public void IsCursed()
        {

        }

    }
}
