using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApplication4.Models;

public class Responsible
{
    // [ForeignKey(nameof(Seedling_Batch))]
    [Key]
    public int BatchId { get; set; }
    // [ForeignKey(nameof(Employee))]
    [Key]
    public int EmployeeId { get; set; }
    [Required]
    public String Role { get; set; }
}