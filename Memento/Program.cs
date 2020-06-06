using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MEMENTO DESIGN PATTERN \n");

            Console.WriteLine("--------");

            Person person = new Person("Atoke","Femi");
            Console.WriteLine("Initial full name is {0} {1}",person.FirstName,person.LastName);

            person.Update("Adetayo","Oyegbile");
            Console.WriteLine("Updated full name is {0} {1}",person.FirstName,person.LastName);

            person.Revert();
            Console.WriteLine("Reverted full name is {0} {1}",person.FirstName,person.LastName);

        }
    }
}
