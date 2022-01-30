using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Jan28
{
    struct book
    {
        private int book_id;
        public void ShowDetails(int id)
        {
            book_id = id;
            Console.WriteLine($"Book Id: {book_id}");
        }
    }
    class Struct_Eg2
    {
        static void Main(string[] args)
        {
            int id;
            Console.WriteLine("Enter the book id: ");
            id = Convert.ToInt32(Console.ReadLine());
            book b = new book();
            b.ShowDetails(id);

            Console.Read();
        }
    }
}
