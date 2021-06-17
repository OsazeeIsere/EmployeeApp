using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        //field data
        private string empName;
        private int empID;
        private float currPay;

        //new field and property
        private string empSSN;
        private int empAge;
        public int Age{get => empAge;set =>empAge = value;}
        public string EmpSSN { get => empSSN; }
        //constructors
        public Employee() { }
        public Employee(string name, int id, float pay)
           : this(name, 0, id, pay) { }
        public Employee(string name,int age, int id,float pay)
        {
            empName = name;
            empAge = age;
            empID = id;
            currPay = pay;
        }

        //methods
        public void GiveBonus(float amount) => currPay += amount;//expression-bodied method
        public void DisplayStatus()
        {
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"Age:{empAge}");
            Console.WriteLine($"ID:{empID}");
            Console.WriteLine("Pay:{0}",currPay);
        }
        //Accessor(get method)
        //public string GetName() => empName;

        ////Mutator(se method)
        //public void SetName(string name)
        //{
        //    //do a check before on incoming value 
        //    //beforr making assignment
        //    if (name.Length > 15)
        //        Console.WriteLine("Error length of name exceed 15 character");
        //    else
        //        empName = name;

        //}

        //instead of using the accessor/mutator(get/set)
        //methods to encapsulate each field data
        //we use the .Net property(a simplification of get/set methods
        //below are the properties
        public string Name
        { get { return empName; }
        set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error length of name exceed 15 character");
                else
                    empName = Name;

            }
        }
        //you could add additional business rules to the rest properties
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
    }
}
