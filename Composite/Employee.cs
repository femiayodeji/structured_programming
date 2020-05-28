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
        private IEmployee DirectSuperior = null;
        public IEmployee Head { get => DirectSuperior;}
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
        public string Name { get; set; }
        public string Office { get; set; }
        public string Designation { get => "Head Manager " +  Office; }
        private IEmployee DirectSuperior;
        public IEmployee Head { get => DirectSuperior;}
        public HeadManager(string name, string office, IEmployee head)
        {
            this.Name = name;
            this.Office = office;
            this.DirectSuperior = head;
        }
        public void ShowDetails(){
            Console.WriteLine("{0} - {1}.", Name, Designation);
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
