using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracker
{
   public interface IEmployee
    {
        void AddEmployeeDetail(string dept, decimal salary);
        void Calc();
        string GetEmployeeInfo();
        
    }
}
