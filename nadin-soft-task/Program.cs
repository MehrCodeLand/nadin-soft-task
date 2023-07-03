using DataAccess.Data;
using DataAccess.DbCon;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using nadin_soft_task.APIs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDb>(options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("myConStr")
    ));
builder.Services.AddScoped<IUserData, UserData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.ConfigAPI();

app.Run();


