﻿// See https://aka.ms/new-console-template for more information
using System;
using AddressBookSystem;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Address Book Program");
            bool end = true;
            Console.WriteLine("SelectNumber\n1.Add Contact\n2.Display\n3.End Of Program");
            Contacts contact = new Contacts();
            AddContact addContact = new AddContact();
            while (end)
            {
                Console.WriteLine("choose program to exicute : ");
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
                        end = false;
                        Console.WriteLine("Program Is Ended");
                        break;

                }
            }
        }
    }
}