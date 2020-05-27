using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DECORATOR DESIGN PATTERN\n");

            Car acCar = new ACCar();
            acCar.CarType();

            Console.WriteLine("\n--------");

            Car soundSystemCar = new SoundSystemCar();
            soundSystemCar.CarType();
        }
    }
}
