using Microsoft.EntityFrameworkCore;
using MultiTenantApp.Database.Cashflow;
using MultiTenantApp.Repositories.Cashflow;
using MultiTenantApp.Services.Transactions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//quick and dirty solution I would not do this in any environment other than my local machine
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(policy => {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddScoped<IMoneyTransactionService, MoneyTransactionService>();
builder.Services.AddScoped<IMoneyTransactionRepository, MoneyTransactionRepository>();
builder.Services.AddDbContext<MoneyTransactionContext>(options => options.UseInMemoryDatabase("TestDb"));

var app = builder.Build();


app.MapOpenApi();
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
