

using APICopy.Data;
using APICopy.Models;

namespace APICopy.Services.Students;

public class StudentService : iStudentService
{
    private readonly DataContent _db;
    public List<string> studentList = new();
    public StudentService(DataContent db)
    {
        _db = db;
    }
    public List<Student> AddStudent(string firstName, string LastName, string hobby)
    {
        Student newStudent = new Student(); 
        newStudent.Name = firstName;
        newStudent.LastName = LastName;
        newStudent.Hobby = hobby;

        _db.Students.Add(newStudent);
        _db.SaveChanges();
        
        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string firstName)
    {
        var student = _db.Students.FirstOrDefault(x => x.Name == firstName);
        if(student != null){
            _db.Students.Remove(student);
            _db.SaveChanges();
        }
        return _db.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }
}
