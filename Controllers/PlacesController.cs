using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace Controllers;
[ApiController]
[Route("/api/[controller]/[action]")]

public class PlacesController : ControllerBase
{
    PlacesService _placesService;
    public PlacesController(PlacesService placesService)
    {
        _placesService = placesService;
    }

    [HttpGet]
    public void GeneratePlaces()
    {
      
        _placesService.GeneratePlaces();
    }
    [HttpGet("GetAll")]
    public List<Place> GetAll()
    {
        return _placesService.GetPlaces();
    }

    [HttpGet("GetPlacesById")]
    public Place GetPlacesById(int id)
    {
        return _placesService.GetPlacesById(id);
    }
    
    [HttpPost("Add")]
    public void Add([FromBody]Place place)
    {
        _placesService.Add(place);
    }
    
}