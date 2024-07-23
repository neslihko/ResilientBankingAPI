using Microsoft.EntityFrameworkCore;
using ResilientBankingAPI.Data;
using ResilientBankingAPI.Resilience;
using ResilientBankingAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<BankingContext>(options =>
    options.UseInMemoryDatabase("BankingDb"));
builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddHttpClient("resilientClient")
    .AddPolicyHandler(ResiliencePolicies.GetRetryPolicy())
    .AddPolicyHandler(ResiliencePolicies.GetCircuitBreakerPolicy());

builder.Services.AddHealthChecks()
    .AddDbContextCheck<BankingContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks("/health");

app.Run();