using System;
using System.Collections.Generic;
using System.Linq;

namespace _102._Dictionaries
{
    internal class Program
    {
        public static Dictionary<string, Employee> employeesDicrectory = new Dictionary<string, Employee>();
        static void Main(string[] args)
        {
            AddValueToDict();
            DirectAccess("CEO");
            FindByIfStatement("HR");
            FindByTryParseMethod("SQA");
            AccessUsingLinq();

        }
        public static void AddValueToDict()
        {
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn",95,200),
                new Employee("Manager", "Joe",35,25),
                new Employee("HR", "Lora",32,21),
                new Employee("Secretary", "petra",28,18),
                new Employee("Lead Developer", "artorias",55,35),
                new Employee("Intern", "Ernest",22,8),
            };

            foreach (Employee emp in employees)
            {
                employeesDicrectory.Add(emp.Role, emp);
            }
            Console.WriteLine("values added to dict");
        }

        public static void DirectAccess(string userinput)
        // this will crashed if key is not found
        {
            Console.WriteLine("called from DirectAccess function");
            Employee specificEmployee = employeesDicrectory[userinput];
            Console.WriteLine($"{specificEmployee.Role},{specificEmployee.Name},{specificEmployee.Age},{specificEmployee.Salary}");
            Console.WriteLine();
        }
        public static void FindByIfStatement(string userinput)
        // this will crashed if key is not found

        {
            Console.WriteLine("called from FindByIfStatement function");
            Employee specificEmployee = employeesDicrectory[userinput];
            if (employeesDicrectory.ContainsKey(userinput))
            {
                Employee emp = employeesDicrectory[userinput];
                Console.WriteLine($"{specificEmployee.Role},{specificEmployee.Name},{specificEmployee.Age},{specificEmployee.Salary}");
            }
            else
            {
            Console.WriteLine($"{userinput} is not available");
            }
            Console.WriteLine();

        }

        public static void FindByTryParseMethod(string userinput)
        // this will not crashed when entry isn't found
        {
            Console.WriteLine("FindByTryParseMethod");
            Employee result = null;
            if (employeesDicrectory.TryGetValue(userinput, out result))
            {
                Console.WriteLine("Value found");
                Console.WriteLine($"Employee Name\t: {result.Name}");
                Console.WriteLine($"Employee Role\t: {result.Role}");
                Console.WriteLine($"Employee Age\t: {result.Age}");
                Console.WriteLine($"Employee Salary\t: {result.Salary}");
            }
            else
            {
                Console.WriteLine($"{userinput} not found");
            }
            Console.WriteLine();

        }
        
        public static void AccessUsingLinq()
        {
            for (int i = 0; i < employeesDicrectory.Count; i++)
            {
                //  using ElementAt(i) to retunr the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDicrectory.ElementAt(i);
                //  print the key 
                Console.WriteLine($"Element {i} has key {keyValuePair.Key}");
                //  storing the value in an employee object
                Employee emp = keyValuePair.Value;
                //  printing properties of the Employee object
                Console.WriteLine($"Employee Role\t: {emp.Role}");
                Console.WriteLine($"Employee Name\t: {emp.Name}");
                Console.WriteLine($"Employee Age\t: {emp.Age}");
                Console.WriteLine($"Employee Salary\t: {emp.Salary}");
                Console.WriteLine("-------------------------");
            }
        }
    }
}
