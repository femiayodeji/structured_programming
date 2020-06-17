using System;
using Mediator.Models;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MEDIATOR DESIGN PATTERN\n");

            Console.WriteLine("------------");
            
            ConcreteMediator mediator = new ConcreteMediator();
            UserA userA = new UserA(mediator);
            UserB userB = new UserB(mediator);
            mediator.UserA = userA; //set user A reference to mediator
            mediator.UserB = userB; //set user B reference to mediator

            userA.Send("Hi");
            Console.WriteLine("----------");
            userB.Send("Hello");

        }
    }
}
