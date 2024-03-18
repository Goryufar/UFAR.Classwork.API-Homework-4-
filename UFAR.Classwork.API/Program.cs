using Microsoft.EntityFrameworkCore;
using UFAR.Classwork.Core.Services;
using UFAR.Classwork.Data.DAO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register ApplicationDBContext with the DI container and say use SQL Server   
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MainDB")));

// Service registration 
// This is called Dependency Injection
// This is a service registration
// This is a service registration for the LibraryService class
// This is a service registration for the ILibraryService interface
// This is a service registration for the LibraryService class that implements the ILibraryService interface
// This is a service registration for the LibraryService class that implements the ILibraryService interface with a scoped lifetime
// Check Transient and Singltone liftimes SOLID principles 
builder.Services.AddScoped<ILibraryService, LibraryService>();
builder.Services.AddScoped<IBookService, BookService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
