using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGenericCollection
{
    public class Employee
    {
        public Employee(int id, string name, string gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public virtual string ToString()
        {
            return $"Employee ID: {Id}, Name: {Name}, Gender: {Gender}, Salary: {Salary} kr";
        }
        
    }
}
