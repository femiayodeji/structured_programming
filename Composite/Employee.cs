using System;

namespace Composite
{
    public interface IEmployee
    {
        IEmployee Head { get;}
        void ShowDetails();
    }    
    public class CEO : IEmployee
    {
        public string Name { get; set; }
        public string Designation = "The Chief Executive of the company";
        public IEmployee Head { get => }
        public CEO(string name)
        {
            this.Name = name;
        }
        public void ShowDetails(){
            Console.WriteLine("{0} - {1}.", Name, Designation);
        }
    }

    public class HeadManager : IEmployee
    {
        private string Name { get; set; }
        private string Designation = "The Head Manager of the company";
        public HeadManager(string name)
        {
            this.Name = name;
        }
        public void ShowDetails(){
            Console.WriteLine("{0} - {1}.", Name, Designation);
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
