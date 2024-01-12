using StudentDatabase.Data;
using StudentDatabase.Models;

namespace StudentDatabase.Services.Students;

    public class SDService : ISDServices
    {
    private readonly DataContext _db;

    public SDService (DataContext db)
    {
        _db = db;
    }

    public List<Student> AddStudent(string firstN, string lastN, string urHobby)
    {
        Student newKid = new();
        newKid.FirstName = firstN;
        newKid.LastName = lastN;
        newKid.Hobby = urHobby;

        _db.Students.Add(newKid);
        _db.SaveChanges();

        return _db.Students.ToList();
    }


    public List<Student> GetList()
    {
        return _db.Students.ToList();
    }

    public List<Student> RemoveStudent(string firstN, string lastN, string urHobby)
    {
        var chosenOne = _db.Students.FirstOrDefault(selectedKid => selectedKid.FirstName == firstN);
        if(chosenOne != null)
        {
            _db.Students.Remove(chosenOne);
            _db.SaveChanges();
        }
        return _db.Students.ToList();
    }

}
