using Microsoft.AspNetCore.Mvc;
using models;
using services;
using testnet;



namespace controllers{
    [ApiController]
[Route("/api/[controller]/[action]")]
    public class DefaultController{
        
        DataContext _datacontext;
        BludosService _bludosService;
        PlacesService _placesService;
        ZakazsService _zakazsService;
        public DefaultController(DataContext data, BludosService bludos, PlacesService places, ZakazsService zakazs)
        {
            _datacontext = data;
            _bludosService = bludos;
            _placesService = places;
            _zakazsService = zakazs;
        }
        [HttpGet]
        public void Default(){
         _bludosService.GenerateBludos(); 
         _placesService.GeneratePlaces();
         _zakazsService.GenerateZakazs();
        }
    }
}