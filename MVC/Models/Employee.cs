using System.ComponentModel.DataAnnotations;

namespace MVC.Models;

public class Employee : Person
{
    
    public string? EmployeeId { get; set; }

    
    public int Age { get; set; }


}