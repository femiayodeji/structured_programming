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
        public void Fly()
        {
            Console.WriteLine("Flying..");
        }
        public void MakeSound()
        {
            Console.WriteLine("Chirp chirp..");
        }
    }
}