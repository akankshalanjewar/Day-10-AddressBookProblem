using System;

namespace UC_CreatePersonDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UC_1_Program uC_2 = new UC_1_Program();
            PersonDetail person = new PersonDetail();
            Console.WriteLine("Enter First Name: ");
            string fname = Console.ReadLine();
            person.FirstName = fname;
            Console.WriteLine("Enter Last Name: ");
            string lname = Console.ReadLine();
            person.LastName = lname;
            Console.WriteLine("Enter Address ");
            string address = Console.ReadLine();
            person.Address = address;
            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();
            person.City = city;
            Console.WriteLine("Enter State: ");
            string state = Console.ReadLine();
            person.State = state;
            Console.WriteLine("Enter pin code: ");
            int pin = int.Parse(Console.ReadLine());
            person.Zip = pin;
            Console.WriteLine("Enter Phone Number: ");
            long number = long.Parse(Console.ReadLine());
            person.PhoneNumber = number;
            Console.WriteLine("Enter Email id: ");
            string email = Console.ReadLine();
            person.Email = email;
            uC_2.addPerson(person);
            uC_2.Display();
        }

    }
    
}
