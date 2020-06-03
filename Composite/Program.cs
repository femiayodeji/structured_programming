using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COMPOSITE DESIGN PATTERN\n");

            IEmployee ceo = new Employee("Atoke", "CEO");
            IEmployee headManager1 = new Employee("Bunmi", "Head Manager 1");
            IEmployee headManager2 = new Employee("Grace", "Head Manager 2");
            IEmployee areaManager = new Employee("Dami", "Area Manager");
            IEmployee agent1 = new Employee("Ife", "Agent");
            IEmployee agent2 = new Employee("John", "Agent");
            IEmployee agent3 = new Employee("Kwaku", "Agent");

            ceo.Add(headManager1);
            ceo.Add(headManager2);

            headManager1.Add(areaManager);

            areaManager.Add(agent1);
            areaManager.Add(agent2);
            areaManager.Add(agent3);
            
            foreach(IEmployee levelOneEmployee in ceo.Subordinates){
                levelOneEmployee.ShowDetails();
            }
            
        }
    }
}
