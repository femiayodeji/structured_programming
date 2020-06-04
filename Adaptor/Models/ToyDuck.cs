using System;

namespace Adaptor.Models
{
    public interface IToyDuck
    {
        void Squeak();
    }

    public class PlasticToyDuck : IToyDuck
    {
        private string _name;
        public PlasticToyDuck(string name)
        {
            _name = name;
        }
        public void Squeak()
        {
            Console.WriteLine("{0} - Squeak..",_name);
        }
    }
}