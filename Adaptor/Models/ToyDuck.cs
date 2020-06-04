using System;

namespace Adaptor.Models
{
    public interface IToyDuck
    {
        void Squeak();
    }

    public class PlasticToyDuck : IToyDuck
    {
        public void Squeak()
        {
            Console.WriteLine("Squeak..");
        }
    }
}