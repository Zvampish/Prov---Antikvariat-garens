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
            actualValue = generator.Next();
            rarity = generator.Next();

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

        public void Printinfo()
        {
            
            
        }
        public void Evaluate()
        {

        }
        public void GetCategory()
        {

        }
        public void GetName()
        {

        }
        public void IsCursed()
        {

        }

    }
}
