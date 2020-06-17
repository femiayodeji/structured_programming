using System;

namespace Mediator.Models
{
    public abstract class BaseUser
    {
        protected IMediator _mediator;

        public BaseUser(IMediator mediator)
        {
            _mediator = mediator;
        }
    }

    public class UserA : BaseUser
    {
        public UserA(IMediator mediator) : base(mediator){}

        public void Send(string msg){
            Console.WriteLine("A send message: " + msg);
            _mediator.SendMessage(this, msg);
        }

        public void Receive(string msg) => Console.WriteLine("A receive message: " + msg);
    }

    public class UserB : BaseUser
    {
        public UserB(IMediator mediator) : base(mediator){}

        public void Send(string msg){
            Console.WriteLine("B send message: " + msg);
            _mediator.SendMessage(this, msg);
        }

        public void Receive(string msg) => Console.WriteLine("B receive message: " + msg);
     }
}