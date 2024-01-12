using APICopy.Models;
using Microsoft.EntityFrameworkCore;

namespace APICopy.Data;

public class DataContent : DbContext
{
    //Allows us to access the database Connection strings
    
    public DataContent(DbContextOptions<DataContent> options) : base(options) //Adding database functionality
    {
        
    }
    public DbSet<Student> Students { get; set; } //creates a table using Db functions with the name Students
    
}
