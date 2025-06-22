using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models;

public class Nursery
{
    [Key]
    public int NurseryId { get; set; }
    
    [Required]
    public string Name { get; set; }
    public DateOnly EstablishedDate { get; set; }
}