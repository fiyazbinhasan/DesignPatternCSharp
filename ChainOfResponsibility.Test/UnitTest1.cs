using System;
using Xunit;

namespace ChainOfResponsibility.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Node nodeA = new Node() { NodeId = 1 };
            Node nodeB = new Node { NodeId = 2 };
            Node nodeC = new Node { NodeId = 3 };

            nodeA.Link(nodeB);
            nodeB.Link(nodeC);

            nodeA.HandleTask(nodeId => Assert.Equal(1, nodeId));

            nodeA.IsBusy = true;

            nodeA.HandleTask(nodeId => Assert.Equal(2, nodeId));

            nodeB.IsBusy = true;

            nodeA.HandleTask(nodeId => Assert.Equal(3, nodeId));
        }
    }
}
