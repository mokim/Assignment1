using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracker
{
    public class Employee : Person, IEmployee
    {
        public string Dept { get; set; }
        public decimal Basic { get; set; }
        public decimal DA; //52% of the basic
        public decimal IT ;//30% of the basic
        public decimal Net_Salary;

        public void AddEmployeeDetail(string dept, decimal basic)
        {

            Dept = dept;
            Basic = basic;
        }
        //calculate net salary of each employee
        public void Calc()
        {
            DA = (decimal)0.52 * Basic;
            IT = (decimal)0.30 * Basic;
            Net_Salary = Basic + DA - IT;
        }
        public string GetEmployeeInfo()
        {
            return string.Format(" Employee Name : {1} |  ID: {0} | Department: {2} | Net Salary: {3} ", Name,Id,Dept,Net_Salary); 
        
        }
    }
}
