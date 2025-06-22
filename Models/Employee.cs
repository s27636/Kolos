using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models;

public class Employee
{
    [Key]
    public int EmployeeId { get; set; }
    
    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly HireDate { get; set; }
}