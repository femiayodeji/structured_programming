namespace Obverser.Models
{
    interface ISubject
    {
        void Register(IObserver Observer);
        void Unregister(IObserver Observer);
        void Notify();
    }
}