using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an employee
            Employee emp1 = new Employee("Winn Dough", 13521);
            Console.WriteLine(emp1.printDetails());

            // Modify an employee
            emp1.name = "Winny Dough";
            emp1.number = 11;
            Console.WriteLine(emp1.printDetails());

            // Create more employees
            Employee emp2 = new Employee("Jane Doe", 21434);
            Employee emp3 = new Employee("Bob Hope", 2534);

            // Create a manager
            Manager man1 = new Manager("Martin", 101);
            Console.WriteLine(man1.printDetails());

            // Create a manager with employess
            List<Employee> ItTeam = new List<Employee>();
            ItTeam.Add(emp1);
            ItTeam.Add(emp3);
            Manager man2 = new Manager("Marvin", 102, ItTeam);
            Console.WriteLine(man2.printDetails());

            // Add employee to a manger
            man1.addEmployee(emp2);
            Console.WriteLine(man1.printDetails());

            // Remove an employee from a manager
            man2.removeEmployee(emp3);
            Console.WriteLine(man2.printDetails());

            Console.ReadLine();// Prevent closing early
        }
    }
}
