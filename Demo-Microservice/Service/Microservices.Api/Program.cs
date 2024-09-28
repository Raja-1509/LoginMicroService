using Microservices.Application.BusinessFacades.Interfaces;
using Microservices.Application.Features.Handlers;
using Microservices.Infrastructure.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers(); // Ensure AddControllers is called to register your API controllers
builder.Services.AddSwaggerGen();
// Register MediatR with a configuration delegate
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(GetEventDetailsQueryHandler).Assembly);
});
builder.Services.AddTransient<IEventRepository, EventRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapControllers(); // Make sure this is called to map controller endpoints

app.Run(); 
