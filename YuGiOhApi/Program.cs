using Microsoft.EntityFrameworkCore;
using System;
using YuGiOhApi.Data;
using YuGiOhApi.Data.Seed;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// EF Core + PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Seed data
// Create a temporary scope to access the app's services outside of a request
using (var scope = app.Services.CreateScope())
{
    // Get the AppDbContext from the DI container so we can talk to the database
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    // Check if the cards table is empty, and if so, seed it with some initial data
    if (!context.Cards.Any())
    {
        // Add all the cards from our seed data tot he context (not saved yet, just tracked)
        context.Cards.AddRange(LobSeedData.GetCards());
        // Save the changes to the database, which will insert the new records
        context.SaveChanges();
    }
}

// Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();