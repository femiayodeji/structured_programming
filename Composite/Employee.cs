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
            Console.WriteLine("This is the Chief Executive of the company.");
        }
    }

}
