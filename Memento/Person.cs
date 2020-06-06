namespace Memento
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MementoPerson Temp { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Temp = new MementoPerson(FirstName,LastName);            
        }
        public void Update(string firstName, string lastName){
            FirstName = firstName;
            LastName = lastName;
        }
        public void Revert(){
            FirstName = Temp.FirstName;
            LastName = Temp.LastName;
        }
    }

    public class MementoPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public MementoPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;            
        }        
    }
}