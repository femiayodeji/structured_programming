namespace Mediator.Models
{
    public class ConcreteMediator : IMediator
    {
        public UserA userA { get; set; }
        public UserB userB { get; set; }
        public void SendMessage(User caller, string msg)
        {
            if(caller == userA){
                userB.Receive(msg);
            }
            else{
                userA.Receive(msg);
            }
        }
    }
}