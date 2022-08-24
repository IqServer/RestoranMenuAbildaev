using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace Controllers;
[ApiController]
[Route("/api/[controller]/[action]")]

public class OrdersController : ControllerBase
{
    OrdersService _ordersService;
    public OrdersController(OrdersService ordersService)
    {
        _ordersService = ordersService;
    }

    [HttpGet]
    public void GenerateOrders()
    {
      
        _ordersService.GenerateOrders();
    }
     [HttpGet("GetAll")]
    public List<Order> GetAll()
    {
        return _ordersService.GetOrders();
    }
    [HttpGet("GetOrdersById")]
    public Order GetOrderById(int id)
    {
        return _ordersService.GetOrdersById(id);
    }
    [HttpPost("Add")]
    public void Add([FromBody]Order order)
    {
        _ordersService.Add(order);
    }

    [HttpOptions("SetOrdersInactive")]
    public void SetOrdersInactive(int id)
    {
        _ordersService.SetInactive(id);
    }

    [HttpOptions("SetOrdersActve")]
    public void SetOrdersActive(int id)
    {
        _ordersService.SetActive(id);
    }

    [HttpPost("UpdateOrders")]
    public void UpdateOrders(Order order)
    {
       _ordersService.UpdateOrders(order);
    }
}






