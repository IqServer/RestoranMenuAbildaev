using testnet;
using models;

namespace services;

public class ZakazsService
{

    readonly DataContext _context;
    public ZakazsService(DataContext context)
    {
        _context = context;

    }

    public List<Zakaz> GetZakazs()
    {
        var zakazs = _context.Zakazs.ToList();

        return zakazs;
    }
    public void GenerateZakazs()
    {
        Zakaz zakaz = new Zakaz();
        zakaz.cost = 228;
        zakaz.bludos = "228";
        zakaz.status = "два два восемь";

         Zakaz zakaz1 = new Zakaz();
        zakaz1.cost = 228;
        zakaz1.bludos = "228";
        zakaz1.status = "два два восемь";

         Zakaz zakaz2 = new Zakaz();
        zakaz2.cost = 228;
        zakaz2.bludos = "228";
        zakaz2.status = "два два восемь";

         Zakaz zakaz3 = new Zakaz();
        zakaz3.cost = 228;
        zakaz3.bludos = "228";
        zakaz3.status = "два два восемь";

        _context.SaveChanges();
        }
    public void Add(Zakaz newZakazs)
    
    {
     _context.Add(newZakazs);
     _context.SaveChanges();

}    
    public Zakaz GetZakazsById(int id)
    {
        return _context.Zakazs.Where(x => x.Id == id ).FirstOrDefault();
    }
    public void Update(Zakaz newZakazs)
    
    {
     _context.Update(newZakazs);
     _context.SaveChanges();

}    
    public void RemovePlaces(int id)
    {
        Place? place = _context.Places.FirstOrDefault(x => x.Id == id);
        _context.Places.Remove(place);
        _context.SaveChanges();



}
    public void SetInactive(int id)
    {
        Place place = _context.Places.FirstOrDefault(x => x.Id == id);
        place.IsActive = false;
        _context.Places.Update(place);
        _context.SaveChanges();
    }
    public void SetActive(int id)
    {
        Place place = _context.Places.FirstOrDefault(x => x.Id == id);
        place.IsActive = true;
        _context.Places.Update(place);
        _context.SaveChanges();
    }  
}
