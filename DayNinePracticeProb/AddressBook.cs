using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DisplayContacts()
        {
            Console.WriteLine("Contacts in Address Book:");
            foreach (Contact contact in contacts)
            {
                Console.WriteLine("Name: {0} {1}", contact.FirstName, contact.LastName);
                Console.WriteLine("Address: {0}", contact.Address);
                Console.WriteLine("City: {0}", contact.City);
                Console.WriteLine("State: {0}", contact.State);
                Console.WriteLine("Zip: {0}", contact.Zip);
                Console.WriteLine("Phone Number: {0}", contact.PhoneNumber);
                Console.WriteLine("Email: {0}", contact.Email);
                Console.WriteLine();
            }
        }

        public bool EditContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                Console.WriteLine("Enter new details for the contact:");

                Console.Write("Enter First Name: ");
                string newFirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string newLastName = Console.ReadLine();

                Console.Write("Enter Address: ");
                string newAddress = Console.ReadLine();

                Console.Write("Enter City: ");
                string newCity = Console.ReadLine();

                Console.Write("Enter State: ");
                string newState = Console.ReadLine();

                Console.Write("Enter Zip: ");
                string newZip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                string newPhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                string newEmail = Console.ReadLine();

                contact.FirstName = newFirstName;
                contact.LastName = newLastName;
                contact.Address = newAddress;
                contact.City = newCity;
                contact.State = newState;
                contact.Zip = newZip;
                contact.PhoneNumber = newPhoneNumber;
                contact.Email = newEmail;

                Console.WriteLine("Contact updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Contact not found.");
                return false;
            }
        }

        public bool DeleteContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Contact not found.");
                return false;
            }
        }

        private Contact FindContact(string firstName, string lastName)
        {
            return contacts.Find(contact =>
                contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contact.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
