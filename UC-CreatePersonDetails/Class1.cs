using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_CreatePersonDetails
{

    public class PersonDetail
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public long PhoneNumber;
        public string Email;

        public string Result()
        {
            return "Name is: " + FirstName + LastName + "\nAddress: " + Address + "\nCity is " + City +
                "\nState is " + State + "\nPostal code is: " + Zip + "\nPhone: " + PhoneNumber + "\nEmail is " + Email;
        }
    }
    internal class UC_1_Program
    {
        public List<PersonDetail> person = new List<PersonDetail>();

        public void Display()
        {
            Console.WriteLine("Address Book is : ");
            foreach (PersonDetail per in person)
            {
                Console.WriteLine(per.Result());
            }
        }

        public void addPerson(PersonDetail p)
        {
            person.Add(p);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"C:\Bridgelabz\Day-10-AddresssBook\UC-CreatePersonDetails\Details.json", jsonData);
        }
                                                                                                                                                                                       
        public UC_1_Program()
        {
            string json = File.ReadAllText(@"C:\Bridgelabz\Day-10-AddresssBook\UC-CreatePersonDetails\Details.json");
            if (json.Length > 0)
            {                                                                                                                                                                           
                person = JsonConvert.DeserializeObject<List<PersonDetail>>(json);
            }
            else
                person = new List<PersonDetail>();

        }
        public void EditPersonDetail(string FirstName)
        {
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].FirstName == FirstName)
                {
                    Console.WriteLine("Enter First Name: ");
                    person[i].FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    person[i].LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address ");
                    person[i].Address = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    person[i].City = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    person[i].State = Console.ReadLine();
                    Console.WriteLine("Enter pin code: ");
                    person[i].Zip = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number: ");
                    person[i].PhoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Email id: ");
                    person[i].Email = Console.ReadLine();
                }
            }
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\Bridgelabz\Visual Studio Assignment\Address-Book-Management\Address-Book-Management\AddressBook\AddressBook\Details.json", jsonData);
        }

    }
}
