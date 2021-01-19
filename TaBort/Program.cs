using System;
using System.Collections.Generic;

namespace TaBort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("Enter: \n(1) for adding new employee. \n(2) to see the registered employees");
            var number = Console.ReadLine();

           
                switch (int.Parse(number))
                {
                    case 1:
                        Console.WriteLine("write employee name");
                        var eName = Console.ReadLine();
                        Console.WriteLine("write employee name");
                        var eSalary = Console.ReadLine();

                        employees.Add(new Employee(eName, int.Parse(eSalary)));

                        break;

                    case 2:

                       
                        for (int i = 0; i < employees.Count; i++)
                        {
                            Console.WriteLine($"Employee{i+1} name is: {employees[i].Name}, Salary is:{employees[i].Salary} \n");

                        }

                        break;

                }
            }

            
        }

     
    }
}
