using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_Jan28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the information of two books :");
            Console.WriteLine("------------------------------------------");
            Hashtable ht = new Hashtable();
            Console.WriteLine("Enter the information of book 1: ");
            Console.Write("Input name of the book: ");
            string bookName1 = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Input the author :");
            string authorName1 = Console.ReadLine();
            ht.Add(bookName1, authorName1);
            Console.Write("\n");
            Console.WriteLine("Enter the information of book 2 :");
            Console.Write("Input name of the book: ");
            string bookName2 = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Input name of the book: ");
            string authorName2 = Console.ReadLine();
            
            ht.Add(bookName2, authorName2);
            foreach (DictionaryEntry item in ht)
            {

                Console.WriteLine("Title = {0}, Author = {1}", item.Key, item.Value);
            }
            Console.Read();

        }
    }
}

