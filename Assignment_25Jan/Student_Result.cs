using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResult_1
{
    class Student
    {
        int RollNo;
        string Name, Class, Sem, Branch;
        int TotalMarks = 0;
        double avg = 0;



        int [] marks = new int [5];
        
         public void getData()
        {
            Console.WriteLine("Enter Roll No of the student: ");
            RollNo =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of the student:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class of the student : ");
            Class = Console.ReadLine();
            Console.WriteLine("Enter Semester of the student: ");
            Sem = Console.ReadLine();
            Console.WriteLine("Enter Branch of the student: ");
            Branch = Console.ReadLine();

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter Subject {0} Marks:", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
       public void displayData()
        {
            Console.WriteLine("----------Student Result-----------");
            Console.WriteLine($"Name of Student: {Name}\n Rollno: {RollNo}\nClass: {Class}\n Sem: {Sem}\nBranch: {Branch}");
            Console.WriteLine($"Totalmarks: {TotalMarks}");
            
        }
        public void displayResult()
        {
           
            for (int i = 0; i < 5; i++)
            {
                TotalMarks = TotalMarks + marks[i];
            }
            avg = TotalMarks / 5.0;
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("Not passed");
                    return;
                }
            }
            if (avg < 50)
            {
                Console.WriteLine("Not passed");
                return;
            }
            Console.WriteLine("Passed");
        }

    }

        class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.getData();
            student.displayData();
            student.displayResult();
        
            Console.Read();
        }
    }
}
