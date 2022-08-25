using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace Controllers;
[ApiController]
[Route("/api/[controller]/[action]")]

public class BludosController : ControllerBase
{
    BludosService _bludosService;
    public BludosController(BludosService bludosService)
    {
        _bludosService = bludosService;
    }

    [HttpGet]
    public void GenerateBludos()
    {
      
        _bludosService.GenerateBludos();
    }

    [HttpGet("GetAll")]
    public List<Bludo> GetAll()
    {
        return _bludosService.GetBludos();
    }
    [HttpGet("GetBludosById")]
    public Bludo GetBludosById(int id)
    {
        return _bludosService.GetBludosById(id);
    }
    [HttpPost("Add")]
    public void Add([FromBody]Bludo bludo)
    {
        _bludosService.Add(bludo);
    }

    [HttpOptions("SetBludosInactive")]
    public void SetBludosInactive(int id)
    {
        _bludosService.SetInactive(id);
    }

    [HttpOptions("SetBludosActve")]
    public void SetBludosActive(int id)
    {
        _bludosService.SetActive(id);
    }

    [HttpPost("UpdateBludos")]
    public void UpdateBludos(Bludo bludo)
    {
       _bludosService.UpdateBludos(bludo);
    }
}


