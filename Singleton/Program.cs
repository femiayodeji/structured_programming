using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SINGLETON PATTERN \n");
            
            ApplicationState state = ApplicationState.GetState();
            state.LoginId = "Instincts";
            state.RoleId = "Developer";
            ApplicationState anotherState = ApplicationState.GetState();
            Console.WriteLine("Login Id: " + anotherState.LoginId);
            Console.WriteLine("Role Id: " + anotherState.RoleId);
            Console.WriteLine((state == anotherState).ToString());

            Console.WriteLine("-----------");
            
            Calculate.Instance.ValueOne = 26.5;
            Calculate.Instance.ValueTwo = 10.5;

            Console.WriteLine("Addition: " + Calculate.Instance.Add());
            Console.WriteLine("Subtraction: " + Calculate.Instance.Sub());
            Console.WriteLine("Multiplication: " + Calculate.Instance.Mul());
            Console.WriteLine("Division: " + Calculate.Instance.Div());
        }
    }
}
