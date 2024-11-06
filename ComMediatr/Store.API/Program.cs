using System.Reflection;
using System.Runtime.Intrinsics.X86;
using MediatR;
using Store.Application.Handlers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddMediatR(typeof(CreateCustomerHandler).Assembly);
//Ou
//builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

var app = builder.Build();

app.MapControllers();

app.Run();