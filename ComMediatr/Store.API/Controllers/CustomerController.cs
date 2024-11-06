using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Commands.Requests;
using Store.Application.Handlers.Interfaces;

namespace Store.API.Controllers;

[ApiController]
[Route("api/v1")]
public class CustomerController : ControllerBase
{
    private readonly IMediator _mediator;

    public CustomerController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost]
    [Route("customers")]
    public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerRequest request)
    {
        var response = await _mediator.Send(request);
        return Ok(response);
    }
}