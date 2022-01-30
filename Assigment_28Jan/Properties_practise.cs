using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineException_Eg
{
    interface Istudent
    {
        //declaring properties
        int StudentId { get; set; }
        string Name { get; set; }
         
    }
    class Dayscholar : Istudent
    {
        public string dStdName;
        public int dStdId;
        //automatic impementation of properties 
        public int StudentId { get; set; }
        public string Name { get; set; }
       
    }
    class Resident : Istudent
    {
        public string place { get; set; }
        private string rStdName;
        private int rStdId;
        public string Name
        {
            //manaual declaration of properties
            get { return rStdName; }
            set { rStdName = value; }
        }
        public int StudentId
        {
            //manaual declaration of properties
            get { return rStdId; }
            set { rStdId = value; }
        }
    }
    class Properties_practise
    {
        static void Main()
        {
            Istudent std = new Dayscholar();

          std.Name = "Namita";
            std.StudentId = 101;
            Console.WriteLine($"Student name: {std.Name} has Id: {std.StudentId}");
            Resident res = new Resident();
            res.Name = "Vamika";
            res.StudentId = 102;
            res.place = "Kolkata";

            Console.WriteLine($"Student name {res.Name} has Id {res.StudentId} lives in {res.place}");


            Console.Read();

        }

    }
}
