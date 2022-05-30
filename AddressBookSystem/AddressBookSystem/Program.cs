// See https://aka.ms/new-console-template for more information
using System;
using AddressBookSystem;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Address Book Program");
            Contacts contact = new Contacts();
            AddAddressBookSystem book = new AddAddressBookSystem();
            book.AddContacts();
            book.Display();

        }
    }
}