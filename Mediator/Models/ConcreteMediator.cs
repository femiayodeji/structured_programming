namespace Mediator.Models
{
    public class ConcreteMediator : IMediator
    {
        public UserA UserA { get; set; }
        public UserB UserB { get; set; }
        public void SendMessage(BaseUser caller, string msg)
        {
            if(caller == UserA){
                UserB.Receive(msg);
            }
            else{
                UserA.Receive(msg);
            }
        }
    }
}