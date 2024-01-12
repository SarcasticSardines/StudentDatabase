using StudentDatabase.Models;
using StudentDatabase.Services.Students;

namespace StudentDatabase.Services.Students;

    public interface ISDServices
    {
        List<Student> AddStudent(string firstN, string lastN, string urHobby);
        List<Student> GetList();
        List<Student> RemoveStudent(string firstN, string lastN, string urHobby);
    }
