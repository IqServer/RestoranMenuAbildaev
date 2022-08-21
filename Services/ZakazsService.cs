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
        zakaz.list = "228";
        zakaz.status = "два два восемь";

         Zakaz zakaz1 = new Zakaz();
        zakaz1.cost = 228;
        zakaz1.list = "228";
        zakaz1.status = "два два восемь";

         Zakaz zakaz2 = new Zakaz();
        zakaz2.cost = 228;
        zakaz2.list = "228";
        zakaz2.status = "два два восемь";

         Zakaz zakaz3 = new Zakaz();
        zakaz3.cost = 228;
        zakaz3.list = "228";
        zakaz3.status = "два два восемь";

        _context.SaveChanges();
        }
    }

