using Coding_Exercise_12_IEnumerable;
using System;
using System.Collections.Generic;

namespace Coding_Exercise_12_IEnumerable
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
        }
            /*  This time, you have to create Contact and PhoneBook classes in the right way that will allow you to run the Main method we provided.
                You have to use this list of Contact:
                Contacts = new List<Contact>{
                      new Contact("Andre", "435797087"),
                      new Contact("Lisa", "435677087"),
                      new Contact("Dine", "3457697087"),
                      new Contact("Sofi", "4367697087")};
                The method Call should print "Calling to X. Phone number is Y" where X is a name and Y is a phone number.
             */
    }
}