using MediatR;
using Store.Application.Commands.Responses;

namespace Store.Application.Commands.Requests;

public class CreateCustomerRequest : IRequest<CreateCustomerResponse>, IRequest
{
    public string Name { get; set; }

    public string Email { get; set; }
}