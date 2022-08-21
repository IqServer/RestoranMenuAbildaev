using Microsoft.EntityFrameworkCore;
using Serilog;
using services;
using testnet;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .Enrich.WithProperty("Firma", "fir4")
    );

// Add services to the container.


ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseNpgsql(configuration.GetConnectionString("Db"));
}
);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<StudentService>();

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
