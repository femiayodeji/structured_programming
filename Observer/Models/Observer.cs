using System;

namespace Observer.Models
{
    public interface IObserver
    {
        void Changed(Object obj);
    }

    public class HeaderColor : IObserver
    {
        public void Changed(Object color){
            Console.WriteLine("Header Color is {0} ", color.ToString());
        }
    }
    public class FooterColor : IObserver
    {
        public void Changed(Object color){
            Console.WriteLine("Footer Color is {0} ", color.ToString());
        }
    }
}