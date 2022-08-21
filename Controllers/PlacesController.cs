using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace Controllers;


class PlacesController : ControllerBase
{
    PlacesService _placesService;
    public PlacesController(PlacesService placesService)
    {
        _placesService = placesService;
    }

    [HttpGet]
    public void GenerateStudent()
    {
      
        _placesService.GeneratePlaces();
    }
}

