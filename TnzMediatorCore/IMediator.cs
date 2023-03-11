namespace TnzMediatorCore {
    public interface IMediator 
    {
        Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request);
    }
}
