using Microsoft.AspNetCore.Mvc;
using models;
using services;
using testnet;



namespace controllers{
    class DefaultController{
        
        DataContext _datacontext;
        BludosService _bludosService;
        public DefaultController(DataContext data, BludosService bludos)
        {
            
        }
    }
}