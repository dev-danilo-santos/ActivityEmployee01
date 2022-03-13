using System;
using System.Collections.Generic;
using System.Text;
using AtividadePOO1.Entities;

namespace AtividadePOO1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee {i + 1} data: ");
                Console.Write("Outsourced? (y/n) ");
                string o = Console.ReadLine().Trim().ToLower();

                
                    Console.WriteLine("Name: ");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Hours: ");
                    int Hours = int.Parse(Console.ReadLine());
                    Console.WriteLine("Value per hour: ");
                    double Value = double.Parse(Console.ReadLine());
                
                if (o.Equals("y"))
                {
                    Console.WriteLine("Additional Charge: ");
                    double AdditionalCharge = double.Parse(Console.ReadLine());
                    Employee Employee = new OutSourcedEmployee(Name, Hours, Value, AdditionalCharge);
                    employees.Add(Employee);
                }
                else
                {

                    Employee Employee = new Employee(Name, Hours, Value);
                    employees.Add(Employee);
                }
            }

            Console.WriteLine("Payments: ");
            StringBuilder sb = new StringBuilder();
            foreach (Employee employee in employees)
            {
                sb.AppendLine($"{employee.Name} - $ {employee.Payment()}");    
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
