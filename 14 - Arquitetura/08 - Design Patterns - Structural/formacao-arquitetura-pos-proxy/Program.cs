using AwesomeShopPatterns.API.Infrastructure;
using AwesomeShopPatterns.API.Infrastructure.Proxies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();
builder.Services.AddHttpContextAccessor();

// Repositório real
builder.Services.AddScoped<CustomerRepository>();

// Proxy é quem será injetado na controller (implementa a interface)
builder.Services.AddScoped<ICustomerRepository, CustomerRepositoryProxy>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
