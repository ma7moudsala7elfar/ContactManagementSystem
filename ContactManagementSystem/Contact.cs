using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementSystem
{
    internal class Contact
    {
        Dictionary<long,User> contacts = new Dictionary<long,User>();

        public void AddContact()
        {
            Console.Write("Enter Phone Number : ");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.Write("\nEnter First Name : ");
            string firstName = Console.ReadLine();
            Console.Write("\nEnter Last Name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("The contact is successfully added to the system");

            contacts[phoneNumber] = new User(firstName, lastName, phoneNumber);

        }

        public void EditContact()
        {
            Console.Write("Enter The Phone Number To Search For The Contact : ");
            long phoneNumber = long.Parse(Console.ReadLine());

            if (contacts.ContainsKey(phoneNumber))
            {
                Console.Write("Enter Phone Number : ");
                long newPhoneNumber = long.Parse(Console.ReadLine());
                Console.Write("\nEnter First Name : ");
                string firstName = Console.ReadLine();
                Console.Write("\nEnter Last Name : ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Contact Edited Succesfully!");
                contacts.Remove(phoneNumber);
                contacts[newPhoneNumber] = new User(firstName, lastName, newPhoneNumber);
            }
            else
            {
                Console.WriteLine("a phone number that doesn't exist");
            }
        }

        public void DeleteContact()
        {
            Console.Write("Enter Phone Number Of The Contact To Delete: ");
            long phoneNumber = long.Parse(Console.ReadLine());

            if (contacts.Remove(phoneNumber))
            {
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void ShowAllContacts()
        {
            Console.WriteLine("All Contacts : ");
            foreach (var user in contacts.Values)
            {
                user.DisplayContact();
            }
        }
    }
}
