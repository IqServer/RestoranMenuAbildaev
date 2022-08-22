using testnet;
using models;

namespace services;

public class BludosService
{

    readonly DataContext _context;
    public BludosService(DataContext context)
    {
        _context = context;

    }

    public List<Bludo> GetBludos()
    {
        var bludos = _context.Bludos.ToList();

        return bludos;
    }
    public void GenerateBludos()
    {
        Bludo bludo = new Bludo();
        bludo.Cost = 228;
        bludo.Kkal = 228;
        bludo.Recipe = "два два восемь";
        bludo.Grams = 228;
        bludo.Photo = "два два восемь";
        _context.Bludos.Add(bludo);

        Bludo bludo2 = new Bludo();
        bludo2.Cost = 228;
        bludo2.Kkal = 228;
        bludo2.Recipe = "два два восемь";
        bludo2.Grams = 228;
        bludo2.Photo = "два два восемь";
        _context.Bludos.Add(bludo2);

        Bludo bludo3 = new Bludo();
        bludo3.Cost = 228;
        bludo3.Kkal = 228;
        bludo3.Recipe = "два два восемь";
        bludo3.Grams = 228;
        bludo3.Photo = "два два восемь";
        _context.Bludos.Add(bludo3);

        Bludo bludo4 = new Bludo();
        bludo4.Cost = 228;
        bludo4.Kkal = 228;
        bludo4.Recipe = "два два восемь";
        bludo4.Grams = 228;
        bludo4.Photo = "два два восемь";
        _context.Bludos.Add(bludo);

        Bludo bludo5 = new Bludo();
        bludo5.Cost = 228;
        bludo5.Kkal = 228;
        bludo5.Recipe = "два два восемь";
        bludo5.Grams = 228;
        bludo5.Photo = "два два восемь";
        _context.Bludos.Add(bludo2);

        
        

        _context.SaveChanges();
    }
    public void Add(Bludo newBludos)
    
    {
     _context.Add(newBludos);
     _context.SaveChanges();

}    
    public Bludo GetBludosById(int id)
    {
        return _context.Bludos.Where(x => x.Id == id ).FirstOrDefault();
    }
    public void Update(Bludo newBludos)
    
    {
     _context.Update(newBludos);
     _context.SaveChanges();

}    
    public void RemovePlace(int id)
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







