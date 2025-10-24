using Patterns.API.Infrastructure.Payments;
using Patterns.API.Infrastructure.Payments.Decorators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPaymentService>(sp =>
{
    var paymentSlipService = new PaymentSlipService();
    return new PaymentServiceDecorator(paymentSlipService);
});

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
