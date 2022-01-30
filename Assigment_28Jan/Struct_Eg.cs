using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Jan28
{
    class Struct_Eg
    {
        struct employee
        {
            public string eName;
            public dob Date;
        }
        struct dob
        {
            public int day;
            public int month;
            public int year;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a nested structure and store data in an array : ");
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Enter the Employee details ");
            Console.Write("\n");
            employee[] emp = new employee[2];

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].eName = nm;

                Console.Write("Input day of the birth : ");
                int dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.day = dd;

                Console.Write("Input month of the birth : ");
                int mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.month = mm;

                Console.Write("input year for the birth : ");
                int yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.year = yy;
            }
        }
    }
}
