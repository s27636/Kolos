using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models;

public class Seedling_Batch
{
    [Key]
    public int BatchId { get; set; }
    
    [ForeignKey("Nursery")]
    public int NurseryId { get; set; }
    [ForeignKey("Tree_Species")]
    public int SpeciesId { get; set; }
    
    [Required]
    public int Quantity { get; set; }
    public DateOnly SownDate { get; set; }
    
    public DateOnly? ReadyDate { get; set; }
}