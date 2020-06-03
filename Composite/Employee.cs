using System;
using System.Collections.Generic;

namespace Composite
{
    public interface IEmployee
    {
        string Name { get; set;}
        string Designation { get; set; }
        List<IEmployee> Subordinates { get; set; }
        void ShowDetails();
        void Add(IEmployee employee);
        void Remove(IEmployee employee);
        void ShowSubordinates();
    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public List<IEmployee> Subordinates { get; set; }

        public Employee(string name, string designation)
        {
            Name = name;
            Designation = designation;
        }

        public void Add(IEmployee employee)
        {
            Subordinates.Add(employee);
        }

        public void ShowSubordinates()
        {
            foreach(IEmployee employee in Subordinates){
                employee.ShowDetails();
            }
        }

        public void Remove(IEmployee employee)
        {
            Subordinates.Remove(employee);
        }

        public void ShowDetails()
        {
            Console.WriteLine("{0} - {1}.", Name, Designation);
        }
    }
}
