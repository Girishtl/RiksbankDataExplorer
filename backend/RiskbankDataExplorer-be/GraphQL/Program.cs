using Application.Interface;
using Application.Service;
using GraphQL.Query;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi


builder.Services.AddTransient<IRiskbankApplication, RiskbankApplication>();

builder.Services.AddTransient<IRiskbankAPIClient, RiskbankAPIClient>();




builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()

    .AddFiltering();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
app.MapGraphQL();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
