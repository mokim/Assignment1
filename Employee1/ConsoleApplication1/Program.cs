using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTracker;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = new List<IEmployee>();
            Console.WriteLine("Enter How Many Employees");
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var employee = new Employee();

                Console.WriteLine("Enter employee name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter employee id");
                var id = Console.ReadLine();

                employee.AddPersonInfo(name, id);

                Console.WriteLine("Enter Employee Department");
                var dept = Console.ReadLine();

                Console.WriteLine("Enter Employee Basic Salary");
                var Basic = decimal.Parse(Console.ReadLine());

                employee.AddEmployeeDetail(dept, Basic);
                employee.Calc();
                employeeList.Add(employee);
            }

            Console.WriteLine("The Employee Informations are\n");

            foreach (IEmployee item in employeeList)
            {
                Console.Write(item.GetEmployeeInfo());
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.WriteLine();

        }
    }

}
