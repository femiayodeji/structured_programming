using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DECORATOR DESIGN PATTERN\n");

            Car acCar = new ACCar();
            Console.WriteLine(acCar.CarType());

            Car soundSystemCar = new SoundSystemCar();
            Console.WriteLine(soundSystemCar.CarType());
        }
    }
}
