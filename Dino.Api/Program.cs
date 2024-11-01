using Dino.Api.Models.Data;
using Dino.Api.Models.Data.DbContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Database");

// Add services to the container.

// When creating migrations we need to create one for each context as they share the same database.
// e.g. "Add-Migration CreateNewDatabase -Context DinosaurDbContext -o Migrations/Dinosaur"
// "-o" is used to specify the outputted migration file.

// Update-Database -Context DinosaurDbContext to implement the migration.

builder.Services.AddDbContext<DinosaurDbContext>(
    options => options.UseSqlServer(connectionString));

builder.Services.AddDbContext<UserDbContext>(
    options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization();
builder.Services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme);

builder.Services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<UserDbContext>()
    .AddApiEndpoints();

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

app.MapIdentityApi<User>();

app.Run();
