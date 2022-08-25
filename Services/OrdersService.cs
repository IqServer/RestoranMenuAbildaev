using testnet;
using models;

namespace services;

public class OrdersService
{

    readonly DataContext _context;
    public OrdersService(DataContext context)
    {
        _context = context;

    }

    public List<Order> GetOrders()
    {
        var orders = _context.Orders.ToList();

        return orders;
    }
    public void GenerateOrders()
    {
        Order order = new Order();
        order.Cost = 228;
        order.Bludos = "Ъ";
        order.Status = "два два восемь";
        
        _context.Orders.Add(order);

         Order order1 = new Order();
        order1.Cost = 228;
        order1.Bludos = "Ъ";
        order1.Status = "два два восемь";
        
        _context.Orders.Add(order1);

         Order order2 = new Order();
        order2.Cost = 228;
        order2.Bludos = "Ъ";
        order2.Status = "два два восемь";
        
        _context.Orders.Add(order2);

         Order order3 = new Order();
        order3.Cost = 228;
        order3.Bludos = "Ъ";
        order3.Status = "два два восемь";
        
        _context.Orders.Add(order3);
    }
    public void Add(Order newOrders)
    
    {
     _context.Add(newOrders);
     _context.SaveChanges();

}    
    public Order GetOrdersById(int id)
    {
        return _context.Orders.Where(x => x.Id == id ).FirstOrDefault();
    }
    public void UpdateOrders(Order order)
    
    {
     _context.Update(order);
     _context.SaveChanges();

    }    
    public void RemoveOrders(int id)
    {
        Order? order = _context.Orders.FirstOrDefault(x => x.Id == id);
        _context.Orders.Remove(order);
        _context.SaveChanges();



}
    public void SetInactive(int id)
    {
        Order order = _context.Orders.FirstOrDefault(x => x.Id == id);
        order.IsActive = false;
        _context.Orders.Update(order);
        _context.SaveChanges();
    }
    public void SetActive(int id)
    {
        Order order = _context.Orders.FirstOrDefault(x => x.Id == id);
        order.IsActive = true;
        _context.Orders.Update(order);
        _context.SaveChanges();
    }  
}       
