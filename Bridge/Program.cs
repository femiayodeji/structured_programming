using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BRIDGE DESIGN PATTERN\n");

            NodeBridge nodeBridge = new NodeBridge();

            NodeA nodeA = new NodeA();
            NodeB nodeB = new NodeB();

            Console.WriteLine(nodeBridge.Reach(nodeA));
            Console.WriteLine(nodeBridge.Reach(nodeB));
        }
    }
}
