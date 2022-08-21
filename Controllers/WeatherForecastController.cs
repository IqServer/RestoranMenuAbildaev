using Microsoft.AspNetCore.Mvc;
using services;
using models;

namespace ПАПА_КИРИЛЛ.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    readonly StudentService _StudentServices;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, StudentService StudentServices )
    {
        _StudentServices = StudentServices;
        _logger = logger;
    }

    [HttpGet(Name = "GetAllStudents")]
    public List<Place> GetAllStudents(){
        var student = _StudentServices.GetStudents();
        return student;


    [HttpGet(Name = "GetWeatherForecast")]
    IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    [HttpGet(Name = "kirill")]
     string kirill(){
        _logger.LogInformation("Был запрос");
        return "Получилось";
    }
}}

