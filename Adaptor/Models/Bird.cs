using System;

namespace Adaptor.Models
{
    public interface IBird
    {
        void Fly();
        void MakeSound();
    }

    public class Bird : IBird
    {
        private String _name;
        public Bird(string name)
        {
            _name = name;
        }
        public void Fly()
        {
            Console.WriteLine("{0} - Flying..",_name);
        }
        public void MakeSound()
        {
            Console.WriteLine("{0} - Chirp chirp..",_name);
        }
    }
}