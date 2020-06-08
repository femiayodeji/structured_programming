using System;

namespace Strategy.Models
{
    public abstract class Fighter
    {
        IKickBehaviour _kickBehaviour;
        IJumpBehaviour _jumpBehaviour;

        public Fighter(IKickBehaviour kickBehaviour, IJumpBehaviour jumpBehaviour)
        {
            _kickBehaviour = kickBehaviour;
            _jumpBehaviour = jumpBehaviour;
        }

        public void Punch(){
            Console.WriteLine("Default punch.");
        }        
        public void Kick(){
            _kickBehaviour.kick();
        }
        public void Jump(){
            _jumpBehaviour.jump();
        }
        public void Roll(){
            Console.WriteLine("Default Roll.");
        }
        
        public void setKickBehaviour(IKickBehaviour kickBehaviour){
            _kickBehaviour = kickBehaviour;
        }
        public void setKickBehaviour(IJumpBehaviour jumpBehaviour){
            _jumpBehaviour = jumpBehaviour;
        }
        public abstract void Display();
    }
}