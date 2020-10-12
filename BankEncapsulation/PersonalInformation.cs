using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BankEncapsulation
{
    public class PersonalInformation
    {
        public PersonalInformation()
        {
            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("---------------");

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();
            Console.WriteLine("---------------");

            Console.WriteLine("What is your street address?");
           StreetAddress = Console.ReadLine();
            Console.WriteLine("---------------");

            Console.WriteLine("Here is more space for your street address, if needed.");
            Address2 = Console.ReadLine();
            Console.WriteLine("---------------");

            Console.WriteLine("In which city do you reside?");
            City = Console.ReadLine();
            Console.WriteLine("---------------");

            Console.WriteLine("In which state do you reside?");
            State = Console.ReadLine();
            Console.WriteLine("---------------");

            Console.WriteLine("What is your zip code?");
            Zip = Console.ReadLine();
            //should this be a int.Parse(console.ReadLine());
            Console.WriteLine("---------------");

            Console.WriteLine("What is your phone number?");
            NumberFormatted = Console.ReadLine();
            Console.WriteLine("---------------");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        private string phoneNumber;

        public string NumberFormatted
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }
        }

        public void PrintPersonal()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(StreetAddress);
            Console.WriteLine(Address2);
            Console.WriteLine(City);
            Console.WriteLine(State);
            Console.WriteLine(Zip);
            Console.WriteLine(phoneNumber);

        }
    }

}
