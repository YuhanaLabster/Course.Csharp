using System;
using System.Collections.Generic;
using System.Linq;


namespace _103._Editing_And_Removing_Entries_in_a_Dictionairy
{
    internal class Program
    {
        public static Dictionary<string, Employee> employeesDicrectory = new Dictionary<string, Employee>();
        static void Main(string[] args)
        {
            string userInput = "HR";
            AddValueToDict();
            FindByTryParseMethod(userInput);
            Update(userInput, "Eleka", 26,18);
            FindByTryParseMethod(userInput);
            Delete(userInput);
            FindByTryParseMethod(userInput);


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

        public static void FindByTryParseMethod(string userinput)
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
        public static void Update (string RoleInput, string Name,int Age,float Rate )
        {
            Employee result = null;
            if (employeesDicrectory.TryGetValue(RoleInput, out result))
            {
                employeesDicrectory[RoleInput] = new Employee(RoleInput, Name, Age, Rate);
                Console.WriteLine("updating data successfull");
            }
            else
            {
                Console.WriteLine($"{RoleInput} not found");
            }
            Console.WriteLine();
        }

        public static void Delete(string RoleInput)
        {
            if (employeesDicrectory.Remove(RoleInput))
            {
                Console.WriteLine($"{RoleInput} was removed");
            }
            else
            {
                Console.WriteLine($"{RoleInput} not not found");
            }
            Console.WriteLine();
        }
    }
}
