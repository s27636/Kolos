using Microsoft.AspNetCore.Mvc;
using WebApplication4.DAL;
using WebApplication4.DTO;
using WebApplication4.Models;

namespace WebApplication4.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ControllerPost : ControllerBase
{
    private readonly AppDbContext _context;

    public ControllerPost(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AddBatch([FromBody] Seedling_BatchDTO request)
    {
    
        var batch = new Seedling_Batch
        {
            BatchId = 1,
            NurseryId = 1,
            SpeciesId = 1,
            Quantity = 700,
            SownDate = DateOnly.FromDateTime(DateTime.Now),
            ReadyDate = DateOnly.FromDateTime(DateTime.Now.AddDays(30)),
            
        };

        await _context.SaveChangesAsync();

        return Ok(new { Message = "Batch dodany" });
    }
}