using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DayNinePracticeProb
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            // Create employee instances for different companies
            Employee company1Employee = new Employee();
            Employee company2Employee = new Employee();

            // Calculate wages for Company 1
            int company1Wage = company1Employee.CalculateWage(25, 22, 120);
            Console.WriteLine("Company 1 Total Wage: " + company1Wage);

            // Calculate wages for Company 2
            int company2Wage = company2Employee.CalculateWage(30, 20, 100);
            Console.WriteLine("Company 2 Total Wage: " + company2Wage);
            */
            Console.WriteLine("WellCome to Adress Book ");

            AddressBook.AddressBook addressBook = new AddressBook.AddressBook();

            // Add a contact
            Contact contact1 = new Contact("John", "Doe", "123 Main St", "City", "State", "12345", "1234567890", "john.doe@example.com");
            addressBook.AddContact(contact1);

            // Display all contacts
            addressBook.DisplayContacts();

            // Edit a contact
            Console.WriteLine("Edit Contact");
            Console.Write("Enter the first name of the contact to edit: ");
            string editFirstName = Console.ReadLine();
            Console.Write("Enter the last name of the contact to edit: ");
            string editLastName = Console.ReadLine();
            bool editSuccess = addressBook.EditContact(editFirstName, editLastName);

            if (editSuccess)
            {
                // Display all contacts after editing
                addressBook.DisplayContacts();
            }

            // Delete a contact
            Console.WriteLine("Delete Contact");
            Console.Write("Enter the first name of the contact to delete: ");
            string deleteFirstName = Console.ReadLine();
            Console.Write("Enter the last name of the contact to delete: ");
            string deleteLastName = Console.ReadLine();
            bool deleteSuccess = addressBook.DeleteContact(deleteFirstName, deleteLastName);

            if (deleteSuccess)
            {
                // Display all contacts after deleting
                addressBook.DisplayContacts();
            }

            Console.ReadLine();
        }
    }
    }

