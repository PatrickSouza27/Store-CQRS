using Store.Application.Handlers;
using Store.Application.Handlers.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddTransient<ICreateCustomerHandler, CreateCustomerHandler>();

var app = builder.Build();

app.MapControllers();

app.Run();