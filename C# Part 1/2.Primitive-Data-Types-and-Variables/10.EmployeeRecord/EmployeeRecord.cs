using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecord
{
    class EmployeeRecord
    {
        static void Main(string[] args)
        {
            /*
             10. A marketing firm wants to keep record of its employees. 
             Each record would have the following characteristics – 
             first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
             Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
            */

            Employee employee = new Employee();
            Employee employeeSecond = new Employee("Ani", "Petrova", 21, 'f', 403, 27560123);

            Console.WriteLine(employee);
            Console.WriteLine(employeeSecond);

        }

        public class Employee
        {
            public string firstName { get; set; }
            public string familyName { get; set; }
            public byte age { get; set; }
            public char gender { get; set; } // (m or f)
            public ushort idNumber { get; set; }
            public uint employeeNumber { get; set; } //(27560000 to 27569999)  

            public Employee()
                : this("Ivan", "Ivanov", 24, 'm')
            {
            }

            public Employee(string aFirstName, string aFamilyName, byte aAge, char aGender = 'm', ushort aIdNumber = 356, uint aEmployeeNumber = 27560002)                
            {
                this.firstName = aFirstName;
                this.familyName = aFamilyName;
                this.age = aAge;
                this.gender = aGender;
                this.idNumber = aIdNumber;
                this.employeeNumber = aEmployeeNumber;
            }

            public override string ToString()
            {
                return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n",
                this.firstName, this.familyName, this.age, this.gender, this.idNumber, this.employeeNumber);
            }
        }
    }
}
