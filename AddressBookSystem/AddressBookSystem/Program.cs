bool end = true;
Console.WriteLine("SelectNumber\n1.Add Contact\n2.Display\n3.EditContact\n4.End Of Program");
Contacts contact = new Contacts();
Address addContact = new AddressBook();
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
            end = false;
            Console.WriteLine("Program Is Ended");
            break;

    }
}