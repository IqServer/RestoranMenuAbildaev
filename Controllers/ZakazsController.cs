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
     [HttpGet("GetAll")]
    public List<Zakaz> GetAll()
    {
        return _zakazsService.GetZakazs();
    }
    [HttpGet("GetProjectById")]
    public Zakaz GetProjectById(int id)
    {
        return _zakazsService.GetZakazsById(id);
    }
    [HttpPost("Add")]
    public void Add([FromBody]Zakaz zakaz)
    {
        _zakazsService.Add(zakaz);
    }
}

