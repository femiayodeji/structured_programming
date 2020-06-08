using System;

namespace Strategy.Models
{
    public class Ogun : Fighter
    {
        public Ogun(IKickBehaviour kickBehaviour, IJumpBehaviour jumpBehaviour) : base(kickBehaviour, jumpBehaviour)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Ogun");
        }
    }

    public class Esun : Fighter
    {
        public Esun(IKickBehaviour kickBehaviour, IJumpBehaviour jumpBehaviour) : base(kickBehaviour, jumpBehaviour)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Esun");
        }
    }

    public class Sango : Fighter
    {
        public Sango(IKickBehaviour kickBehaviour, IJumpBehaviour jumpBehaviour) : base(kickBehaviour, jumpBehaviour)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Sango");
        }
    }
}