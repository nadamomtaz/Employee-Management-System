using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_2
{
    internal class Manager:Employee
    {
        public Manager(int id, string name,  int departmentId, decimal salary)
    : base( id ,name , departmentId,salary)
        {
          
        }
        List<Employee>TeamMember=new List<Employee>();
    }
}
