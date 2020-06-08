using System;
using Memento.checkpoint;
using Memento.checkPoint;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MEMENTO DESIGN PATTERN \n");

            Console.WriteLine("--------");

            Person person = new Person("Atoke","Femi");
            Console.WriteLine("Initial full name is {0}",person.FullName);

            person.Update("Adetayo","Oyegbile");
            Console.WriteLine("Updated full name is {0}",person.FullName);

            person.Revert();
            Console.WriteLine("Reverted full name is {0}",person.FullName);

            Console.WriteLine("--------");

            Console.WriteLine("Game Player statistics");

            // step 1 - set initial data
            PlayerStatistics _statistics = new PlayerStatistics();
            _statistics.LevelId = 1;
            _statistics.Score = 100;
            _statistics.CheckPointTime = DateTime.Now;
            _statistics.PrintStatistics();

            // step 2 - create and store data in memento instance
            CheckPointCareTaker _careTaker = new CheckPointCareTaker();
            _careTaker.checkPoint = _statistics.CreateCheckPoint(_statistics);
            Console.WriteLine(Environment.NewLine);

            // step 3 -  change the data
            _statistics.LevelId = 4;
            _statistics.Score = 320;
            _statistics.CheckPointTime = DateTime.Now.Add(new TimeSpan(0, 0, 40, 0));
            _statistics.PrintStatistics();
            Console.WriteLine(Environment.NewLine);

            // step 4 - restore the initial data
            _statistics.RestoreCheckPoint(_careTaker.checkPoint);
            _statistics.PrintStatistics();

        }
    }
}
