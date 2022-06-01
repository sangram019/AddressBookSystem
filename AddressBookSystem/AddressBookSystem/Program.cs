﻿using System;
using AddressBook;
using AddressBookSystem;

namespace AddressBook
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Address Book Program");
            bool end = true;
            Console.WriteLine("SelectNumber\n1)Add Contact\n2)Display\n3)EditContact\n4)DeleteContact\n5)AddMultipleContact\n6)Adding Unique Name \n7)DisplayUniqueNamen\n8)Search Person by city or State\n9)Count Persons by city or State\n10)End Of Program");
            Contacts contact = new Contacts();
            AddressBook addContact = new AddressBook();
            while (end)
            {
                Console.WriteLine("choose program to exucute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addContact.CreateContact();
                        break;
                    case 2:
                        addContact.Display();
                        break;
                    case 3:
                        addContact.EditContact();
                        break;
                    case 4:
                        addContact.DeleteContact();
                        break;
                    case 5:
                        Console.WriteLine("How many no. of contacts");
                        int n = Convert.ToInt32(Console.ReadLine());
                        addContact.AddMultipleContacts(n);
                        break;
                    case 6:
                        addContact.AddUniqueName();
                        break;
                    case 7:
                        addContact.DisplayUniqueName();
                        break;
                    case 8:
                        addContact.SearchByCityState();
                        break;
                    case 9:
                        addContact.CountByCityState();
                        break;
                    case 10:
                        end = false;
                        Console.WriteLine("Program Is Ended");
                        break;

                }
            }
        }
    }
}