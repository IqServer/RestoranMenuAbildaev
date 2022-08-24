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
        bludo.Price = 228;
        bludo.Calories = 228;
        bludo.Recipe = "два два восемь";
        bludo.Grams = 228;
        bludo.Photo = "два два восемь";
        bludo.CategoryId = 1;
        bludo.Description = " очень вкусно";
        bludo.Name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo2 = new Bludo();
        bludo2.Price = 228;
        bludo2.Calories = 228;
        bludo2.Recipe = "два два восемь";
        bludo2.Grams = 228;
        bludo2.Photo = "два два восемь";
        bludo2.CategoryId = 1;
        bludo2.Description = " очень вкусно";
        bludo2.Name = "Супь";
        _context.Bludos.Add(bludo);

       Bludo bludo3 = new Bludo();
        bludo3.Price = 228;
        bludo3.Calories = 228;
        bludo3.Recipe = "два два восемь";
        bludo3.Grams = 228;
        bludo3.Photo = "два два восемь";
        bludo3.CategoryId = 1;
        bludo3.Description = " очень вкусно";
        bludo3.Name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo4 = new Bludo();
        bludo4.Price = 228;
        bludo4.Calories = 228;
        bludo4.Recipe = "два два восемь";
        bludo4.Grams = 228;
        bludo4.Photo = "два два восемь";
        bludo4.CategoryId = 1;
        bludo4.Description = " очень вкусно";
        bludo4.Name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo5 = new Bludo();
        bludo5.Price = 228;
        bludo5.Calories = 228;
        bludo5.Recipe = "два два восемь";
        bludo5.Grams = 228;
        bludo5.Photo = "два два восемь";
        bludo5.CategoryId = 1;
        bludo5.Description = " очень вкусно";
        bludo5.Name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo6 = new Bludo();
        bludo6.Price = 228;
        bludo6.Calories = 228;
        bludo6.Recipe = "два два восемь";
        bludo6.Grams = 228;
        bludo6.Photo = "два два восемь";
        bludo6.CategoryId = 1;
        bludo6.Description = " очень вкусно";
        bludo6.Name = "Супь";
      
        Bludo bludo7 = new Bludo();
        bludo7.Price = 228;
        bludo7.Calories = 228;
        bludo7.Recipe = "два два восемь";
        bludo7.Grams = 228;
        bludo7.Photo = "два два восемь";
        bludo7.CategoryId = 1;
        bludo7.Description = " очень вкусно";
        bludo7.Name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo8 = new Bludo();
        bludo8.Price = 228;
        bludo8.Calories = 228;
        bludo8.Recipe = "два два восемь";
        bludo8.Grams = 228;
        bludo8.Photo = "два два восемь";
        bludo8.CategoryId = 1;
        bludo8.Description = " очень вкусно";
        bludo8.Name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo9 = new Bludo();
        bludo9.Price = 228;
        bludo9.Calories = 228;
        bludo9.Recipe = "два два восемь";
        bludo9.Grams = 228;
        bludo9.Photo = "два два восемь";
        bludo9.CategoryId = 1;
        bludo9.Description = " очень вкусно";
        bludo9.Name = "Супь";
        _context.Bludos.Add(bludo);

        Bludo bludo10 = new Bludo();
        bludo10.Price = 228;
        bludo10.Calories = 228;
        bludo10.Recipe = "два два восемь";
        bludo10.Grams = 228;
        bludo10.Photo = "два два восемь";
        bludo10.CategoryId = 1;
        bludo10.Description = " очень вкусно";
        bludo10.Name = "Супь";
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







