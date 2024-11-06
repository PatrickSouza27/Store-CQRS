using MediatR;
using Store.Application.Commands.Requests;
using Store.Application.Commands.Responses;

namespace Store.Application.Handlers;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
{
    public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        // verifica se o cliente já está cadastrado
        //valida os dados
        //insere o cliente
        //envia email de boas vindas
        
        var customer = new CreateCustomerResponse
        { 
            Id = Guid.NewGuid(),
            Name = "patrick",
            Email = "patrick@gmail.com",
            Date = DateTime.Now
        };

        return Task.FromResult(customer);
    }
}