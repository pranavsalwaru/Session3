using BoilerplateSession3.Context;
using BoilerplateSession3.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

// Add services to the container.
string con = builder.Configuration.GetConnectionString("LocalConnectionString");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(con));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();    

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
