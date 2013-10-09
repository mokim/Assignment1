using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracker
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public void AddPersonInfo(string id, string name)
        {
            Name = name;
            Id = id;
        }

    }
}
