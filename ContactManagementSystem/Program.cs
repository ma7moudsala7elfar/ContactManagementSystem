namespace ContactManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            Console.WriteLine("1. Add Contact\n2. Edit Contact\n3. Delete Contact\n4. Show All Contacts\n5. Exit");
            Console.WriteLine();

            bool exit = false;
            while (!exit)
            {
                Console.Write("Enter Your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        contact.AddContact();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    break;
                    case 2:
                        contact.EditContact();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        break;
                    case 3:
                        contact.DeleteContact();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        break;
                    case 4:
                        contact.ShowAllContacts();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        break;
                    case 5:
                        exit = true;
                    break;
                }
            }
        }
    }
}
