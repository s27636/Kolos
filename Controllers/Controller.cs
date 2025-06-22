// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using WebApplication4.DAL;
// using WebApplication4.DTO;
//
// [ApiController]
// [Route("api/nurseries")]
// public class NurseriesController : ControllerBase
// {
//     private readonly AppDbContext _context;
//
//     public NurseriesController(AppDbContext context)
//     {
//         _context = context;
//     }
// //
// //     [HttpGet("{id}/batches")]
// //     public async Task<IActionResult> GetNurseryWithBatches(int id)
// //     {
// //         // var nursery = await _context.Nurseries.FindAsync(id);
// //         // var batches = _context.SeedlingBatches.Where(b => b.NurseryId == id);
// //         //
// //         // if (nursery == null)
// //         //     return NotFound("Nursery not found.");
// //         //
// //         // var result = new NurseryDTO
// //         // {
// //         //     NurseryId = nursery.NurseryId,
// //         //     Name = nursery.Name,
// //         //     EstablishedDate = nursery.EstablishedDate,
// //         //     batches = batches.Select(b => new Seedling_BatchDTO
// //         //     {
// //         //         BatchId = b.BatchId,
// //         //         Quantity = b.Quantity,
// //         //         SownDate = b.SownDate,
// //         //         ReadyDate = b.ReadyDate,
// //         //         Species = new Tree_SpeciesDTO
// //         //         {
// //         //             LatinName = b.Species.LatinName,
// //         //             GrowthTimeInYears = b.Species.GrowthTimeInYears
// //         //         },
// //         //         Responsible = b.Responsibles.Select(r => new ResponsibleDTO
// //         //         {
// //         //             FirstName = r.FirstName,
// //         //             LastName = r.LastName,
// //         //             Role = r.Role
// //         //         }).ToList()
// //         //     }).ToList()
// //         // };
// //
// //         // return Ok(result);
// //     };
// // }