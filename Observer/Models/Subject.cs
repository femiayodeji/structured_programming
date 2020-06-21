using System.Collections.Generic;
using System.Linq;

namespace Obverser.Models
{
    public interface ISubject
    {
        void Register(IObserver Observer);
        void Unregister(IObserver Observer);
        void Notify();
    }

    public class ColorSubject : ISubject
    {
        private string _color = "blue";
        public string Color {
            get => _color;
            set{
                _color = value;
                Notify();
            }
        }       

        private HashSet<IObserver> _observers = new HashSet<IObserver>();

        public void Register(IObserver observer) => _observers.Add(observer);

        public void Unregister(IObserver observer) => _observers.Remove(observer);
        public void Notify() => _observers.ToList().ForEach(observer => observer.Changed(Color));
    }
}