using Services.Customers.Application.Commands;
using Services.Customers.Application.View_Models;
using Services.Customers.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Customers.Application.Queries.Handlers
{
    public class GetCustomerByIdHandler :
        IRequestHandler<GetCustomerById, GetCustomerByIdViewModel>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetCustomerByIdHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<GetCustomerByIdViewModel> Handle(GetCustomerById request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.Id);

            return new GetCustomerByIdViewModel(customer.Id, customer.FullName, customer.BirthDate, AddressDto.ToDto(customer.Address));
        }
    }
}