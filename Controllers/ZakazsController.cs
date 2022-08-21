using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace Controllers;


class ZakazsController : ControllerBase
{
    ZakazsService _zakazsService;
    public ZakazsController(ZakazsService zakazsService)
    {
        _zakazsService = zakazsService;
    }

    [HttpGet]
    public void GenerateStudent()
    {
      
        _zakazsService.GenerateZakazs();
    }
}

