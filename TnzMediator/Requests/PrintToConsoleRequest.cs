using TnzMediatorCore;

namespace TnzMediatorConsole.Requests {
    public class PrintToConsoleRequest : IRequest<bool> {
        public string Text { get; init; }
    }
}
