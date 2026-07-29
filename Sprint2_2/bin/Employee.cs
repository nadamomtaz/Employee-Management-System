using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_2
{
    internal class Employee
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
        public DateTime HireDate{ get; set; }
        public decimal Salary { get; set; }
        public List<string> skills { get; set; }
        public Employee(int id , string name , int DepartmentId,decimal salary) {
            this.id = id;
            this.Name = name;
            this.DepartmentId = DepartmentId;
            this.Salary = salary;
            HireDate=DateTime.Now;
        }
    }
}
