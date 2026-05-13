using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Tasks
{
    internal class Employee : Person
    {
        //public string Name;
        public double Salary;

        public List<Role> EmpRole;
        public void Display()
        {
            string roles = EmpRole != null ? string.Join(",", EmpRole) : "None";
            Console.WriteLine($"Name : {Name} :: Salary : {Salary} :: Role : [{roles}]");
        }
        public void AssignRole(Role role)
        {
           if(EmpRole == null)
            {
                EmpRole = new List<Role>();
            }
            if (!EmpRole.Contains(role))
            {
                EmpRole.Add(role);
            }
        }
        public bool HasRole(Role role)
        {
            return EmpRole != null && EmpRole.Contains(role);
        }
        public override string ToString()
        {
            return $"Employee Name: {Name} , Age {Age}, National ID {NationalID}, Salary {Salary}";
        }
    }
}
