using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace Controllers;
[ApiController]
[Route("/api/[controller]/[action]")]

public class ZakazsController : ControllerBase
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

    [HttpOptions("SetZakazsInactive")]
    public void SetZakazsInactive(int id)
    {
        _zakazsService.SetInactive(id);
    }

    [HttpOptions("SetZakazsActve")]
    public void SetZakazsActive(int id)
    {
        _zakazsService.SetActive(id);
    }

    [HttpPost("UpdateZakazs")]
    public void UpdateZakazs(Zakaz zakaz)
    {
       _zakazsService.UpdateZakazs(zakaz);
    }
}






