using System;

namespace UC_CreatePersonDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC_1_Program uc_3 = new UC_1_Program();
            uc_3.Display();
            Console.WriteLine("Enter First name to Edit that particular Item: ");
            string name = Console.ReadLine();
            uc_3.EditPersonDetail(name);
            uc_3.Display();


        }

    }
    
}
