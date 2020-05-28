using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COMPOSITE DESIGN PATTERN\n");

            IEmployee areaManager = new AreaManager();
            IEmployee headManager1 = new HeadManager1();
            IEmployee ceo = new CEO();

            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(areaManager);
            employees.Add(headManager1);
            employees.Add(ceo);

            foreach(IEmployee employee in employees){
                employee.Designation();
            }
        }
    }
}
