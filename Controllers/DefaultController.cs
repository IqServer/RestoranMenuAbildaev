using Microsoft.AspNetCore.Mvc;
using models;
using services;
using testnet;



namespace controllers{
    [ApiController]
[Route("/api/[controller]/[action]")]
    public class DefaultController{
        
        BludosService _bludosService;
        PlacesService _placesService;
        OrdersService _ordersService;
        DataContext _context;
        public DefaultController(DataContext data,
         BludosService bludos, PlacesService places, OrdersService orders)
        {
            _context = data;
            _bludosService = bludos;
            _placesService = places;
            _ordersService = orders;
        }
        [HttpGet]
        public void Default(){
         _bludosService.GenerateBludos(); 
         _placesService.GeneratePlaces();
         _ordersService.GenerateOrders();
        }

        [HttpGet]
        public void CreateDB(){
         _context.CreateBDNew();
        }

    }
}