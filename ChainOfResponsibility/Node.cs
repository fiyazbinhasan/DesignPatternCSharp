using System;
namespace ChainOfResponsibility
{
    public class Node : INode
    {
        public int NodeId { get; set; }
        public bool IsBusy { get; set; }

        public INode _nextNode;

        public void HandleTask(Action<int> action)
        {
            if (IsBusy)
                _nextNode.HandleTask(action);
            else
                action(NodeId);
        }

        public void Link(INode node)
        {
            _nextNode = node;
        }
    }
}
