using System;
using System.Linq;

class PrintCompanyData
{
    static void Main(string[] args)
    {
        /*
         3. A company has name, address, phone number, fax number, web site and manager. 
            The manager has first name, last name, age and a phone number. 
            Write a program that reads the information about a company and its manager and prints them on the console.
        */


        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company address: ");
        string address = Console.ReadLine();

        Console.Write("Enter company phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Enter company fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Enter company web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Enter company manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter company manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Enter company manager's age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Enter company manager's phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("\nInformation about the company and its manager");
        Console.WriteLine(new string('-', 45));
        Console.WriteLine("\nCOMPANY");
        Console.WriteLine(new string('-', 7));
        Console.WriteLine(
            "\n{0,-15}: {1,20}\n{2,-15}: {3,20}\n{4,-15}: {5,20}\n{6,-15}: {7,20}\n{8,-15}: {9,20}",
             "Name", companyName, "Address", address, "Phone number", phoneNumber, "Fax number", faxNumber, "Web site", webSite);

        Console.WriteLine("\nMANAGER");
        Console.WriteLine(new string('-', 7));
        Console.WriteLine(
            "\n{0,-15}: {1,20}\n{2,-15}: {3,20}\n{4,-15}: {5,20}\n{6,-15}: {7,20}",
            "First name", managerFirstName, "Last name", managerLastName, "Age", managerAge, "Phone number", managerPhoneNumber);

    }
}
