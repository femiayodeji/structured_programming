namespace Mediator.Models
{
    public interface IMediator
    {
        void SendMessage(User caller, string msg);
    }
}