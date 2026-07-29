using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_2
{
    internal class Company
    {
        List<Employee>ActiveEmployee = new List<Employee>();
        Dictionary<int,Department> Departments = new Dictionary<int,Department>();
        Queue<Employee> Onboarding=new Queue<Employee>();
        Stack<string> ActionHistory = new Stack<string>();
        HashSet<string> skilles = new HashSet<string>();
        public void AddEmployee(Employee employee)
        {
            Onboarding.Enqueue(employee);
            ActionHistory.Push($"{employee.Name} added to Onboarding");
        }
        public void AddtoActiveEmployee() {
            if (Onboarding.Count == 0) { Console.WriteLine(" No employee onboarding");
                return;
            }
            
                Employee e1 = Onboarding.Dequeue();
                ActiveEmployee.Add(e1);
                ActionHistory.Push($"{e1.Name} removed from Onboarding && added to Active Employee");
            
        }
        public void AddNewDepartment(Department department){
            Departments.Add(department.Id, department);
            ActionHistory.Push($"{department.Name}  added to Departments");
        }
        public void AddEmployeeSkills(string skill , Employee employee)
        {
            employee.Skills.Add(skill);
            skilles.Add(skill);
            ActionHistory.Push($" {skill} added to{employee.Name}");
        }
        public Employee SearchById(int id) { 
            foreach (var items in ActiveEmployee)
            {
                if (items.id == id)
                {
                    return items;
                }
            }
            return null;
        }
        public Employee SearchByName(string name) {
            foreach (var items in ActiveEmployee)
            {
                if (items.Name == name)
                {
                    return items;
                }
            }
            return null;

        }
        public void DisplayEmployeesByDepartment(int departmentId)
        {
            if (!Departments.ContainsKey(departmentId))
            {
                Console.WriteLine("Department not found");
                return;
            }
            Department dept = Departments[departmentId]; 
            Console.WriteLine($"Employees in {dept.Name}:");

            foreach (var emp in ActiveEmployee) 
            {
                if (emp.DepartmentId == departmentId)
                {
                    Console.WriteLine(emp.Name);
                }
            }
        }


    }
}
