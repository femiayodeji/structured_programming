using System;
using Adaptor.Models;

namespace Adaptor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADAPTOR DESIGN PATTERN\n");

            Console.WriteLine("----------");

            Bird raven = new Bird("Raven");
            PlasticToyDuck toyDuck = new PlasticToyDuck("Duck toy");
            
            // wrapper a bird into an adapter 
            // in order to make a bird behave like a toyduck
            IToyDuck birdAdapter = new BirdAdapter(raven);

            raven.Fly();
            raven.MakeSound();

            toyDuck.Squeak();

            birdAdapter.Squeak();
        }
    }
}
