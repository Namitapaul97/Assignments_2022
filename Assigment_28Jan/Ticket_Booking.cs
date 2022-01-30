using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Jan28
{


    class TicketException : ApplicationException
    {
        public TicketException(string msg) : base(msg)
        {

        }         
    }
    class Passenger
    {
        public string name;
        public int age;
        public void passangerDetails()
        {
            Console.WriteLine("Enter passanger name: ");
            name = Console.ReadLine();
            
            Console.WriteLine("Enter passenger Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Passanger name: "+name);

            Console.WriteLine("Passenger Age:" + age);
        }
        public void Ticket_Booking(int no_of_tickets)
        {
            if (no_of_tickets > 5)
            {
                throw (new TicketException("cannot book more than 2 tickets"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
           
            
                Passenger p = new Passenger();
               
                p.passangerDetails();
           
                Console.WriteLine("Enter no. of tickets to be booked: ");
                int T = Convert.ToInt32(Console.ReadLine());

                try
                {
                    p.Ticket_Booking(T);
                }
               
                 catch (TicketException te)
                {
                        Console.WriteLine(te.Message);
                }
            Console.Read();
            
        }

    }
}

