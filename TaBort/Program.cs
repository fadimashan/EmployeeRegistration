using System;
using System.Collections.Generic;

namespace TaBort
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopCondition = true;
            List<Employee> employees = new List<Employee>();

            while (loopCondition)
            {
                Console.WriteLine(" ______________________________________");
                Console.WriteLine("Enter: \n(1) for adding new employee. \n(2) to see the registered employees. \n(3) Exit.");

                var input = Console.ReadLine();
                int number;

                if (int.TryParse(input, out number))
                {
                    number = int.Parse(input);

                    if (number == 1 || number == 2 || number == 3)
                    {
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine("write employee name");
                                var eName = Console.ReadLine();
                                bool isSalary = true;
                                Console.WriteLine("write employee salary");
                                while (isSalary)
                                {
                                 
                                    var eSalary = Console.ReadLine();
                                    int salary;

                                    if (int.TryParse(eSalary, out salary))
                                    {
                                        employees.Add(new Employee(eName, int.Parse(eSalary)));
                                        isSalary = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Salary should be numpers, Please enter the salary!");
                                        isSalary = true;

                                    }
                                }
                                break;

                            case 2:

                                if (employees.Count != 0)
                                {
                                    for (int i = 0; i < employees.Count; i++)
                                    {
                                        Console.WriteLine(" ______________________________________");
                                        Console.WriteLine($"Employee{i + 1} name is: {employees[i].Name}, Salary is:{employees[i].Salary}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There is no employees registerd!");
                                }

                                break;

                            case 3:
                                loopCondition = false;
                                Console.WriteLine("Thanks, Bye!");
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter option number (1 or 2)");
                    }
                }
                else
                {
                    Console.WriteLine("Enter option number (1 or 2)");
                }


            }
        }

    }
}
