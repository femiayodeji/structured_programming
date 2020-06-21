using System;
using Observer.Models;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OBSERVER DESIGN PATTERN\n");

            Console.WriteLine("----------");

            IObserver headerstyle = new HeaderColor();
            IObserver footerstyle = new FooterColor();
            ColorSubject colorNotifier = new ColorSubject();

            colorNotifier.Register(headerstyle);
            colorNotifier.Register(footerstyle);
            colorNotifier.Color = "red";

            Console.WriteLine("----------");

            colorNotifier.Color = "yellow";

        }
    }
}
