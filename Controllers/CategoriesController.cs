using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace Controllers;
[ApiController]
[Route("/api/[controller]/[action]")]

public class CategoriesController : ControllerBase
{
    CategoriesService _CategoriesService;
    public CategoriesController(CategoriesService CategoriesService)
    {
        _CategoriesService = CategoriesService;
    }

    [HttpGet("GenerateCategories")]
    public void GenerateCategories()
    {
      
        _CategoriesService.GenerateCategories();
    }
    [HttpGet("GetAll")]
    public List<Categories> GetAll()
    {
        return _CategoriesService.GetCategories();
    }

    [HttpGet("GetCategoriesById")]
    public Categories GetCategoriesById(int id)
    {
        return _CategoriesService.GetCategoriesById(id);
    }
    
    [HttpPost("Add")]
    public void Add([FromBody]Categories Categories)
    {
        _CategoriesService.Add(Categories);
    }
    
    [HttpOptions("SetCategoriesInactive")]
    public void SetCategoriesInactive(int id)
    {
        _CategoriesService.SetInactive(id);
    }

    [HttpOptions("SetCategoriesActve")]
    public void SetCategoriesActive(int id)
    {
        _CategoriesService.SetActive(id);
    }

    [HttpPost("UpdateCategories")]
    public void UpdateCategories(Categories Categories)
    {
       _CategoriesService.UpdateCategories(Categories);
    }
}



