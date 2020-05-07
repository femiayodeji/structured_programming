using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate.Instance.ValueOne = 26.5;
            Calculate.Instance.ValueTwo = 10.5;

            Console.WriteLine("Addition: " + Calculate.Instance.Add());
            Console.WriteLine("Subtraction: " + Calculate.Instance.Sub());
            Console.WriteLine("Multiplication: " + Calculate.Instance.Mul());
            Console.WriteLine("Division: " + Calculate.Instance.Div());
        }
    }
}
