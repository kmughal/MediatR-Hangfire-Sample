namespace Web.Extensions
{
    using Hangfire;
    using MediatR;
    using System.Threading.Tasks;

    public static  class MediatorExtensions
    {
        public static void Enqueue<TResult>(this IMediator mediator, IRequest<TResult> request)
        {
            var backgroundJobClient = new BackgroundJobClient();
            backgroundJobClient.Enqueue<MediatorHangfireBridge>(x => x.Send(request));
        }
    }

    public class MediatorHangfireBridge
    {

        public IMediator _mediator;

        public MediatorHangfireBridge(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Send<TResult>(IRequest<TResult> request)
        {
            await _mediator.Send(request);
        }
    }
}
