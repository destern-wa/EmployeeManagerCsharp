using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCsharp
{
    class Manager : Employee
    {
        private List<Employee> _employees;

        public Manager(string name, int number) : base(name, number)
        {
            _employees = new List<Employee>();
        }
        public Manager(string name, int number, List<Employee> employees) : base(name, number)
        {
            _employees = employees;
        }

        public List<Employee> Employees {
            get { return _employees; }
        }

        public void addEmployee(Employee newEmployee)
        {
            _employees.Add(newEmployee);
        }

        public void removeEmployee(Employee oldEmployee)
        {
            _employees.Remove(oldEmployee);
        }

        public new string printDetails()
        {
            string managerDetails = "Manager " + name + " / " + number + "\n";
            if (_employees.Count == 0)
            {
                return managerDetails + "(no employess)";
            }
            managerDetails += "Employees:";
            foreach (Employee employee in _employees)
            {
                managerDetails += "\n- " + employee.printDetails();
            }
            return managerDetails;
        }
    }

}
