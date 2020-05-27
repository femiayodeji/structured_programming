using System;

namespace Decorator
{
    public class Car
    {
        public virtual void CarType() => Console.Write("Simple car");
    }

    public class ACCar : Car 
    {
        public override void CarType(){
            base.CarType();
            Console.Write(" with AC");
        }
    }

    public class SoundSystemCar : Car
    {
        public override void CarType(){
            base.CarType();
            Console.Write(" with Sound System");
        }
    }
}