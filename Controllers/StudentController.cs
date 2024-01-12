
using APICopy.Models;
using APICopy.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace API_ConrtollersAndRoutes.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController
{
    
    public List<string> studentList = new();

    public iStudentService StudentService { get; }

    public StudentController(iStudentService studentService)
    {
        StudentService = studentService;
    }

    [HttpGet] //use Get to push/pull Data
    [Route("GetStudents")]
    public List<Student> GetStudents()
    {
        return StudentService.GetStudents();
    }

    [HttpPost] //use Post to add data 
    [Route("AddStudent/{firstName}/{lastName}/{hobby}")]
    public List<Student> AddStudent(string firstName, string lastName, string hobby)
    {
        return StudentService.AddStudent(firstName, lastName, hobby);
    }


    [HttpDelete]
    [Route("DeleteStudent/{firstName}")]
    public List<Student> DeleteStudent(string firstName)
    {
        return StudentService.DeleteStudent(firstName);
    }
}
