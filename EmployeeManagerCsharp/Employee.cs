using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCsharp
{
    class Employee
    {
        protected String _name;
        protected int _number;

        public Employee(String name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public String name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int number
        {
            get { return _number; }
            set { _number = value; }
        }

        public String printDetails()
        {
            return _name + " / " + _number;
        }
    }
    }
