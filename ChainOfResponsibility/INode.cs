using System;
namespace ChainOfResponsibility
{
    public interface INode
    {
        int NodeId { get; set; }
        bool IsBusy { get; set; }

        void Link(INode node);
        void HandleTask(Action<int> action);
    }
}
