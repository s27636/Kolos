namespace WebApplication4.DTO;

public class Seedling_BatchDTO
{
    public int BatchId { get; set; }
    public int SpeciesId { get; set; }
    public int NurseryId { get; set; }
    public int Quantity { get; set; }
    public DateOnly SownDate { get; set; }
    
    public DateOnly? ReadyDate { get; set; }
}