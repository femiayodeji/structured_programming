using System;

namespace Composite
{
    public interface IEmployee
    {
        string Name { get; set; }
        void Designation();
    }    
    public class CEO : IEmployee
    {
        public virtual string Name { get; set; }
        public virtual void Designation(){
            Console.WriteLine("{0} - The Chief Executive of the company.", Name);
        }
    }

    public class HeadManager1 : CEO, IEmployee
    {
        public override string Name { get; set; }
        public override void Designation(){
            Console.WriteLine("{0} - The Head Manager 1 of the company.", Name);
        }
    }

    public class HeadManager2 : CEO, IEmployee
    {
        public override string Name { get; set; }
        public override void Designation(){
            Console.WriteLine("{0} - The head Manager 2 of the company.", Name);
        }
    }

    public class AreaManager : HeadManager1, IEmployee
    {
        public override string Name { get; set; }
        public override void Designation(){
            Console.WriteLine("{0} - The Area Manager under the HM1", Name);
        }
    }
}
