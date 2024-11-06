using Store.Application.Commands.Requests;
using Store.Application.Commands.Responses;

namespace Store.Application.Handlers.Interfaces;

public interface ICreateCustomerHandler
{
    CreateCustomerResponse Handle(CreateCustomerRequest request);
}