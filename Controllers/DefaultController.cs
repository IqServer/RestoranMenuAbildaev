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
        CategoriesService _categoriesService;
        DataContext _context;
        public DefaultController(DataContext data,
         BludosService bludos, PlacesService places, OrdersService orders, CategoriesService categories)
        {
            _context = data;
            _bludosService = bludos;
            _placesService = places;
            _ordersService = orders;
            _categoriesService = categories;
        }
        [HttpGet]
        public void Default(){
         _bludosService.GenerateBludos(); 
         _placesService.GeneratePlaces();
         _ordersService.GenerateOrders();
         _categoriesService.GenerateCategories();
        }
        
        

        [HttpGet]
        public void CreateDB(){
         _context.CreateBDNew();
        }

    }
}
    

