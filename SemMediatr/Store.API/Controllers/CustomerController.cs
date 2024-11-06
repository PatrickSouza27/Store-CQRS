using Microsoft.AspNetCore.Mvc;
using Store.Application.Commands.Requests;
using Store.Application.Handlers.Interfaces;

namespace Store.API.Controllers;

[ApiController]
[Route("api/v1")]
public class CustomerController : ControllerBase
{
    private readonly ICreateCustomerHandler _createCustomerHandler;

    public CustomerController(ICreateCustomerHandler createCustomerHandler)
    {
        _createCustomerHandler = createCustomerHandler;
    }
    
    [HttpPost]
    [Route("customers")]
    public IActionResult CreateCustomer([FromBody] CreateCustomerRequest request)
    {
        var response = _createCustomerHandler.Handle(request);
        return Ok(response);
    }
}