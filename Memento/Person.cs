namespace Memento
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;            
        }
        public void Update(string firstName, string lastName){
            FirstName = firstName;
            LastName = lastName;
        }
    }
}