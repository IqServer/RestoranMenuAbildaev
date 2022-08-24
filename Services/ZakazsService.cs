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
        zakaz.Cost = 228;
        zakaz.Bludos = "228";
        zakaz.Status = "два два восемь";

         Zakaz zakaz1 = new Zakaz();
        zakaz1.Cost = 228;
        zakaz1.Bludos = "228";
        zakaz1.Status = "два два восемь";

         Zakaz zakaz2 = new Zakaz();
        zakaz2.Cost = 228;
        zakaz2.Bludos = "228";
        zakaz2.Status = "два два восемь";

         Zakaz zakaz3 = new Zakaz();
        zakaz3.Cost = 228;
        zakaz3.Bludos = "228";
        zakaz3.Status = "два два восемь";

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
    public void UpdateZakazs(Zakaz zakaz)
    
    {
     _context.Update(zakaz);
     _context.SaveChanges();

}    
    public void RemoveZakazs(int id)
    {
        Zakaz? zakaz = _context.Zakazs.FirstOrDefault(x => x.Id == id);
        _context.Zakazs.Remove(zakaz);
        _context.SaveChanges();



}
    public void SetInactive(int id)
    {
        Zakaz zakaz = _context.Zakazs.FirstOrDefault(x => x.Id == id);
        zakaz.IsActive = false;
        _context.Zakazs.Update(zakaz);
        _context.SaveChanges();
    }
    public void SetActive(int id)
    {
        Zakaz zakaz = _context.Zakazs.FirstOrDefault(x => x.Id == id);
        zakaz.IsActive = true;
        _context.Zakazs.Update(zakaz);
        _context.SaveChanges();
    }  
}
