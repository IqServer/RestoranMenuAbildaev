using Microsoft.EntityFrameworkCore;
using Serilog;
using services;
using testnet;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .Enrich.WithProperty("Firma", "fir4")
    .WriteTo.Seq("http://localhost:5341")
    );
    builder.Services.AddCors(options => options.AddPolicy("AllowAll",
    builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    }));

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
builder.Services.AddScoped<PlacesService>();
builder.Services.AddScoped<OrdersService>();
builder.Services.AddScoped<BludosService>();
builder.Services.AddScoped<OrdersService>();
builder.Services.AddScoped<CategoriesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseRouting();

app.UseCors("AllowAll");

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
