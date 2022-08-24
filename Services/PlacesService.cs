using testnet;
using models;

namespace services;

public class PlacesService
{

    readonly DataContext _context;
    public PlacesService(DataContext context)
    {
        _context = context;

    }

    public List<Place> GetPlaces()
    {
        var places = _context.Places.ToList();

        return places;
    }
    public void GeneratePlaces()
    {
        Place place = new Place();
        place.Title = "228";
        place.Adress = "228";
        place.FIO = "два два восемь";
        _context.Places.Add(place);

        Place place1 = new Place();
        place1.Title = "228";
        place1.Adress = "228";
        place1.FIO = "два два восемь";
        _context.Places.Add(place1);

        Place place2 = new Place();
        place2.Title = "228";
        place2.Adress = "228";
        place2.FIO = "два два восемь";
        _context.Places.Add(place2);

        Place place3 = new Place();
        place3.Title = "228";
        place3.Adress = "228";
        place3.FIO = "два два восемь";
        _context.Places.Add(place3);

         _context.SaveChanges();
        }
    public void Add(Place newPlaces)
    
    {
     _context.Add(newPlaces);
     _context.SaveChanges();

}    
    public Place GetPlacesById(int id)
    {
        return _context.Places.Where(x => x.Id == id ).FirstOrDefault();
    }
    public void UpdatePlaces(Place place)
    
    {
     _context.Update(place);
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
