using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HOME_TASK_5_Q_NO_1
{
    internal class Library
    {
        private Book[] books;
        private int Bookcount;


        public Library()
        {

            books = new Book[100];
            Bookcount = 0;

        }

        public void Addbooks(Book book1)
        {
            books[Bookcount] = book1;
            Bookcount++;
            Console.WriteLine(" Book Added Successfully");
        }

        public void ListAllBooks()
        {
            Console.WriteLine(" All the books are Following ");
            for (int i = 0; i < Bookcount; i++)
            {
                Console.WriteLine("TITLE" + books[i].Title);
                Console.WriteLine("AURTHOR" + books[i].Aurthor);
                Console.WriteLine("GENER" + books[i].Gener);
                Console.WriteLine("Publication Years" + books[i].PublicationYear);
            }

        }
        public void SearchBook(string keyword)
        {
            Console.WriteLine($"Search Value for the Keyword = {keyword}");
            for (int i = 0; i < Bookcount; i++)
            {
                if (books[i].Title == keyword || books[i].Aurthor == keyword || books[i].Gener == keyword)
                {
                    Console.WriteLine("TITLE" + books[i].Title);
                    Console.WriteLine("AURTHOR" + books[i].Aurthor);
                    Console.WriteLine("GENER" + books[i].Gener);
                    Console.WriteLine("Publication Years" + books[i].PublicationYear);
                    
                }
            }
        }
    }
}

            