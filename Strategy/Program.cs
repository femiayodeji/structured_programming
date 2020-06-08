using System;
using Strategy.Models;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STRATEGY DESIGN PATTERN\n");

            Console.WriteLine("--------");

            //moves
            IJumpBehaviour shortJump = new ShortJump();
            IJumpBehaviour longJump = new LongJump();
            IKickBehaviour tornadoKick = new TornadoKick();
            
            //create fighter
            Fighter sango = new Sango(tornadoKick, shortJump);
            sango.Display();

            //fight
            sango.Punch();
            sango.Kick();
            sango.Jump();

            //change behaviour dynamically(runtime)
            sango.setKickBehaviour(longJump);
            sango.Jump();
        }
    }
}
