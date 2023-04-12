using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Sector sector1 = new Sector("1");
            Shelve shelveA = new Shelve("A");

            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            shelveA.AddBook(book1);
            shelveA.AddBook(book2);
            sector1.AddShelve(shelveA);
        }
    }
}