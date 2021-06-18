using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        //field data
        private string empName;
        private int empID;
        private float currPay;

        //new field and property
        private string empSSN;
        private int empAge;
        //constructors
        public Employee() { }
        public Employee(string name, int id, float pay)
           : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            empName = name;
            empAge = age;
            empID = id;
            currPay = pay;
        }
    }
}
