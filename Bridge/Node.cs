namespace Bridge
{
    public interface INode
    {
        string Reach();
    }
  
    public class NodeA : INode
    {
        public string Reach() => "Reached to node A";
    }

    public class NodeB : INode
    {
        public string Reach() => "Reached to node B";
    }
}