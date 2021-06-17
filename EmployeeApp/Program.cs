using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> fun with encapsulation");
            Employee em = new Employee("Jason",233,50000);
            em.DisplayStatus();

            //use the get/set method to interact with the empName
            em.Name=("Joan Oyenmwosa Isere");
            Console.WriteLine($"The new employee is:{em.Name}");

            Employee joe = new Employee();
            joe.Age++;//this clean and allowed
            Console.ReadLine();

        }
    }
}
