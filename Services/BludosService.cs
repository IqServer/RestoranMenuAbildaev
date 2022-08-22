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
        bludo.price = 228;
        bludo.calories = 228;
        bludo.recipe = "два два восемь";
        bludo.grams = 228;
        bludo.Photo = "два два восемь";
        bludo.CategoryId = 1;
        bludo.description = " очень вкусно";
        bludo.name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo2 = new Bludo();
        bludo2.price = 228;
        bludo2.calories = 228;
        bludo2.recipe = "два два восемь";
        bludo2.grams = 228;
        bludo2.Photo = "два два восемь";
        bludo2.CategoryId = 1;
        bludo2.description = " очень вкусно";
        bludo2.name = "Супь";
        _context.Bludos.Add(bludo);

       Bludo bludo3 = new Bludo();
        bludo3.price = 228;
        bludo3.calories = 228;
        bludo3.recipe = "два два восемь";
        bludo3.grams = 228;
        bludo3.Photo = "два два восемь";
        bludo3.CategoryId = 1;
        bludo3.description = " очень вкусно";
        bludo3.name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo4 = new Bludo();
        bludo4.price = 228;
        bludo4.calories = 228;
        bludo4.recipe = "два два восемь";
        bludo4.grams = 228;
        bludo4.Photo = "два два восемь";
        bludo4.CategoryId = 1;
        bludo4.description = " очень вкусно";
        bludo4.name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo5 = new Bludo();
        bludo5.price = 228;
        bludo5.calories = 228;
        bludo5.recipe = "два два восемь";
        bludo5.grams = 228;
        bludo5.Photo = "два два восемь";
        bludo5.CategoryId = 1;
        bludo5.description = " очень вкусно";
        bludo5.name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo6 = new Bludo();
        bludo6.price = 228;
        bludo6.calories = 228;
        bludo6.recipe = "два два восемь";
        bludo6.grams = 228;
        bludo6.Photo = "два два восемь";
        bludo6.CategoryId = 1;
        bludo6.description = " очень вкусно";
        bludo6.name = "Супь";
      
        Bludo bludo7 = new Bludo();
        bludo7.price = 228;
        bludo7.calories = 228;
        bludo7.recipe = "два два восемь";
        bludo7.grams = 228;
        bludo7.Photo = "два два восемь";
        bludo7.CategoryId = 1;
        bludo7.description = " очень вкусно";
        bludo7.name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo8 = new Bludo();
        bludo8.price = 228;
        bludo8.calories = 228;
        bludo8.recipe = "два два восемь";
        bludo8.grams = 228;
        bludo8.Photo = "два два восемь";
        bludo8.CategoryId = 1;
        bludo8.description = " очень вкусно";
        bludo8.name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo9 = new Bludo();
        bludo9.price = 228;
        bludo9.calories = 228;
        bludo9.recipe = "два два восемь";
        bludo9.grams = 228;
        bludo9.Photo = "два два восемь";
        bludo9.CategoryId = 1;
        bludo9.description = " очень вкусно";
        bludo9.name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo10 = new Bludo();
        bludo10.price = 228;
        bludo10.calories = 228;
        bludo10.recipe = "два два восемь";
        bludo10.grams = 228;
        bludo10.Photo = "два два восемь";
        bludo10.CategoryId = 1;
        bludo10.description = " очень вкусно";
        bludo10.name = "Супь";
        _context.Bludos.Add(bludo);

      
      
        _context.Bludos.Add(bludo);

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
    public void UpdateBludos(Bludo bludo)
    {
     _context.Bludos.Update(bludo);
     _context.SaveChanges();
    }    
    public void RemoveBludos(int id)
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







