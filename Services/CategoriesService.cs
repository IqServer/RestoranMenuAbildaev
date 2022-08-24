using testnet;
using models;

namespace services;

public class CategoriesService
{

    readonly DataContext _context;
    public CategoriesService(DataContext context)
    {
        _context = context;

    }

    public List<Categories> GetCategories()
    {
        var categories = _context.Categories.ToList();

        return categories;
    }
    public void GenerateCategories()
    {
        Categories categories = new Categories();
        categories.Tab = "228";
        _context.Categories.Add(categories);

         Categories categories1 = new Categories();
        categories1.Tab = "228";
        _context.Categories.Add(categories1);

        _context.SaveChanges();
    }
    public void Add(Categories newCategories)
    
    {
     _context.Add(newCategories);
     _context.SaveChanges();

}    
    public Categories GetCategoriesById(int id)
    {
        return _context.Categories.Where(x => x.Id == id ).FirstOrDefault();
    }
    public void UpdateCategories(Categories categories)
    {
     _context.Categories.Update(categories);
     _context.SaveChanges();
    }    
    public void RemoveCategories(int id)
    {
        Categories? Categories = _context.Categories.FirstOrDefault(x => x.Id == id);
        _context.Categories.Remove(Categories);
        _context.SaveChanges();
    }
    public void SetInactive(int id)
    {
        Categories Categories = _context.Categories.FirstOrDefault(x => x.Id == id);
        Categories.IsActive = false;
        _context.Categories.Update(Categories);
        _context.SaveChanges();
    }
    public void SetActive(int id)
    {
        Categories Categories = _context.Categories.FirstOrDefault(x => x.Id == id);
        Categories.IsActive = true;
        _context.Categories.Update(Categories);
        _context.SaveChanges();
    }
    }







