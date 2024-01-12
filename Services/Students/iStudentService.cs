using APICopy.Models;

namespace APICopy.Services.Students;

public interface iStudentService
{
    List<Student> GetStudents();
    List<Student> AddStudent(string firstName, string lastName, string hobby);
    List<Student> DeleteStudent(string firstName);

}
