using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementSystem
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }

        public User(string firstName, string lastName, long phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public void DisplayContact()
        {
            Console.WriteLine($"Contact Name : {FirstName} {LastName} \nPhone Number : {PhoneNumber}");
        }
    }
}
