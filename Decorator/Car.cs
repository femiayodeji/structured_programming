namespace Decorator
{
    public class Car
    {
        public virtual string CarType() => "Simple car";
    }

    public class ACCar : Car{
        public override string CarType() => "AC Car";
    }
}