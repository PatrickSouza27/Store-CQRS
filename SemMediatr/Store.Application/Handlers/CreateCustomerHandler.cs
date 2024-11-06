using Store.Application.Commands.Requests;
using Store.Application.Commands.Responses;
using Store.Application.Handlers.Interfaces;

namespace Store.Application.Handlers;

public class CreateCustomerHandler : ICreateCustomerHandler
{
    public CreateCustomerResponse Handle(CreateCustomerRequest request)
    {
        // verifica se o cliente já está cadastrado
        //valida os dados
        //insere o cliente
        //envia email de boas vindas
        
        return new CreateCustomerResponse
        { 
            Id = Guid.NewGuid(),
            Name = "patrick",
            Email = "patrick@gmail.com",
            Date = DateTime.Now
        };
    }
}