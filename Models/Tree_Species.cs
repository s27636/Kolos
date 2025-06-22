using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models;

public class Tree_Species
{
    [Key]
    public int SpeciesId { get; set; }
    
    [Required]
    public string LatinName { get; set; }
    public int GrowthTimeInYears { get; set; }
}