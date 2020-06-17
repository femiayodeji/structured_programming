namespace Mediator.Models
{
    public interface IMediator
    {
        void SendMessage(BaseUser caller, string msg);
    }
}