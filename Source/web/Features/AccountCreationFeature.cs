namespace Web.Features
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountCreationRequest : IRequest<AccountCreationRequestHandler>
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Pin { get; set; }

        public string Address { get; set; }
    }

    public class AccountCreationRequestHandler : IRequestHandler<AccountCreationRequest, AccountCreationRequestHandler>
    {
        public Task<AccountCreationRequestHandler> Handle(AccountCreationRequest request, CancellationToken cancellationToken)
        {
            return default;
        }
    }
}