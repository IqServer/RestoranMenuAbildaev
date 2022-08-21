using testnet;
using models;

namespace services;

public class StudentService{

    readonly DataContext _context;
    public StudentService(DataContext context)
    {
        _context = context;

    }

    public List<Place> GetStudents(){
       var students =  _context.Places.ToList();
        
        return students;
    }
 public void GenerateStudent(){
          Place student = new Place();

        student.FIO ="1";
        _context.Places.Add(student);
          Place student2 = new Place();

        student2.FIO ="2";
        _context.Places.Add(student2);

        Place student3 = new Place();

        student3.FIO ="3";
        _context.Places.Add(student3);
        _context.SaveChanges();
    }


}



