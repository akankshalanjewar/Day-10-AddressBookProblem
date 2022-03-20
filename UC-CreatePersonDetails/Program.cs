using System;

namespace UC_CreatePersonDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Welcome To AddressBook Program");

                UC_1_Program uC_1 = new UC_1_Program();
                PersonDetail person = new PersonDetail();
                person.FirstName = "Akanksha";
                person.LastName = "Lanjewar";
                person.Address = "Nandavan";
                person.City = "Nagpur";
                person.State = "Maharashtra";
                person.Zip = 425409;
                person.PhoneNumber = 4634678632;
                person.Email = "akankshalanjewar@gmail.com";
                uC_1.addPerson(person);
                uC_1.Display();
            
        }
    }
}
