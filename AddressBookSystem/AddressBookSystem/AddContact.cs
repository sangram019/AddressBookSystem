using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddContact
    {
        List<Contacts> addressBook = new List<Contacts>();
        Contacts contact = new Contacts();
        public AddContact()
        {
            Contacts contact1 = new Contacts()
            {
               
                FirstName = "Sangram",
                LastName = "Keshari",
                Address = "bhadrak",
                Email = "SkB@gmail.com",
                PhoneNumber = "9087567743",
                City = "Bbsr",
                State = "Odisha",
                ZipCode = "756137"
            };
            Contacts contact2 = new Contacts()
            {
               
                FirstName = "Biki",
                LastName = "Behera",
                Address = "Banglore",
                Email = "bikicool@gmail.com",
                PhoneNumber = "90404080",
                City = "bANGLORE",
                State = "karnataka",
                ZipCode = "560037"
            };
            addressBook.Add(contact1);
            addressBook.Add(contact2);
        }
        public void CreateContact()
        {
           
            Console.WriteLine("Enter Your First: ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address: ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter Your Email Id: ");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter Your PhoneNumber: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your City: ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter Your State: ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Your Zip Code: ");
            contact.ZipCode = Console.ReadLine();
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.Email + "\n" + contact.PhoneNumber + "\n" + contact.City + "\n" + contact
                    .State + "\n" + contact.ZipCode);
                Console.WriteLine("\n");
            }
        }
    }
}