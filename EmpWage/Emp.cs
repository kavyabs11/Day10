using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class Emp
    {
        public void Wage()
        {
            int fullTime = 1;
            int empHr = 0;
            int wagePerHr = 20;
            int empWage = 0;
            //new operator creates an object from the class by allocating memory for the new object and returning reference to thet memory
            Random random = new Random();
            int attendCheck = random.Next(0, 2);
            if (attendCheck == fullTime)
            {
                empHr = 8;
                Console.WriteLine($"The Employee is present");
            }
            else
            {
                empHr = 0;
                Console.WriteLine($"The Employee wage is absent");
            }
            empWage = empHr * wagePerHr;
            Console.WriteLine($"The Empployee wage is {empWage}");
        }
    }
}
