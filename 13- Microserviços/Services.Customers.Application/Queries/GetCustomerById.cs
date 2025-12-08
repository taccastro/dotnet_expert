using MediatR;
using Services.Customers.Application.View_Models;
using System;

namespace Services.Customers.Application.Queries
{
    public class GetCustomerById : IRequest<GetCustomerByIdViewModel>
    {
        public GetCustomerById(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}