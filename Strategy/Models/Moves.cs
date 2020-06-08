using System;

namespace Strategy.Models
{
    public class LightningKick : IKickBehaviour
    {
        public void Kick()
        {
            Console.WriteLine("Lightning Kick.");
        }
    }

    public class TornadoKick : IKickBehaviour
    {
        public void Kick(){
            Console.WriteLine("Tornado Kick.");
        }
    }

    public class ShortJump : IJumpBehaviour
    {
        public void Jump(){
            Console.WriteLine("Short Jump.");
        }
    }

    public class LongJump : IJumpBehaviour
    {
        public void Jump(){
            Console.WriteLine("Long Jump.");
        }
    }

}