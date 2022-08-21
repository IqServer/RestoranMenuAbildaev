using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace Controllers;


class BludosController : ControllerBase
{
    BludosService _bludosService;
    public BludosController(BludosService bludosService)
    {
        _bludosService = bludosService;
    }

    [HttpGet]
    public void GenerateStudent()
    {
      
        _bludosService.GenerateBludos();
    }
}

