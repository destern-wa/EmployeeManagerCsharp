using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCsharp
{
    class Employee
    {
        protected string _name;
        protected int _number;

        public Employee(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string printDetails()
        {
            return _name + " / " + _number;
        }
    }
    }
