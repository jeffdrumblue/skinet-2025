using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DESKTOP-OAMCPNN\MSSQLSERVER02

/*builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();*/

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(opt =>
{
    //opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

    opt.UseSqlServer("Server=DESKTOP-OAMCPNN\\MSSQLSERVER02,1433;Database=skinet;User Id=SA;Password=Spebs$38;TrustServerCertificate=True")
        .EnableDetailedErrors();
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();
