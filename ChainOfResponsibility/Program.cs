using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeA = new Node() { NodeId = 1};
            Node nodeB = new Node { NodeId = 2 };
            Node nodeC = new Node { NodeId = 3 };

            nodeA.Link(nodeB);
            nodeB.Link(nodeC);

            nodeA.HandleTask((int nodeId) => Console.WriteLine($"Task handled by Node: {nodeId}"));

            nodeA.IsBusy = true;

            nodeA.HandleTask((int nodeId) => Console.WriteLine($"Task handled by Node: {nodeId}"));

            nodeB.IsBusy = true;

            nodeA.HandleTask((int nodeId) => Console.WriteLine($"Task handled by Node: {nodeId}"));

            Console.ReadLine();

        }
    }
}
