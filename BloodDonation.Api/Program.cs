using BloodDonation.Application.Commands.Donors.CreateDonor;
using Microsoft.AspNetCore.Cors.Infrastructure;
using MediatR;
using BloodDonation.Application.Configuration;
using BloodDonation.Infrastructure.Configuration;
using BloodDonation.Api.Filters;
using BloodDonation.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => options.Filters.Add(typeof(ValidationFilter)));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblyContaining(typeof(CreateDonorCommand));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseExceptionHandler(opt => { });
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
