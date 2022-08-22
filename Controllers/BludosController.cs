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

    [HttpGet("GetAll")]
    public List<Bludo> GetAll()
    {
        return _bludosService.GetBludos();
    }
    [HttpGet("GetProjectById")]
    public Bludo GetProjectById(int id)
    {
        return _bludosService.GetBludosById(id);
    }
    [HttpPost("Add")]
    public void Add([FromBody]Bludo bludo)
    {
        _bludosService.Add(bludo);
    }


}

