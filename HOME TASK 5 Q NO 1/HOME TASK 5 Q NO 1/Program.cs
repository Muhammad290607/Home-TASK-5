using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME_TASK_5_Q_NO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "OOP";
            book1.Aurthor = "AbdulQadeerBilal";
            book1.Gener= "BSSEBOOK";
            book1.PublicationYear = 2000;

            Book book2 = new Book();
            book2.Title = "DLD";
            book2.Aurthor = "SanaIkram";
            book2.Gener = "BSSEBOOK";
            book2.PublicationYear = 1998;

            Library library_Object = new Library();
            library_Object.Addbooks(book1);
            library_Object.Addbooks(book2);

            //Display All Books 
            library_Object.ListAllBooks();

             Console.WriteLine(" Enter Gener of Book");
            string Gener = Console.ReadLine();
            

            library_Object.SearchBook(Gener);

            Console.ReadLine();

        }
    }
}
