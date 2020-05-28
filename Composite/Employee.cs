using System;

namespace Composite
{
    public interface IEmployee
    {
        void Designation();
    }    
    public class CEO : IEmployee
    {
        public virtual void Designation(){
            Console.WriteLine("The Chief Executive of the company.");
        }
    }

    public class HeadManager1 : CEO, IEmployee
    {
        public override void Designation(){
            Console.WriteLine("The Head Manager 1 of the company.");
        }
    }

    public class HeadManager2 : CEO, IEmployee
    {
        public override void Designation(){
            Console.WriteLine("The head Manager 2 of the company.");
        }
    }
}
