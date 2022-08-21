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
        _context.Places.Add(place);

        Place place2 = new Place();
        place2.Title = "228";
        place2.Adress = "228";
        place2.FIO = "два два восемь";
        _context.Places.Add(place);

        Place place3 = new Place();
        place3.Title = "228";
        place3.Adress = "228";
        place3.FIO = "два два восемь";
        _context.Places.Add(place);

         _context.SaveChanges();
        }
        
    }