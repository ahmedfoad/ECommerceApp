using Microsoft.AspNetCore.Mvc;
using EPayment.Core.Entities;
using EPayment.Infrastrucure.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace EPayment.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(StoreContext context) : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetProducts(CancellationToken cancellationToken)
    {
        var products = await context.Products.AsNoTracking().ToListAsync(cancellationToken);
        return Ok(products);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetProduct(int id, CancellationToken cancellationToken)
    {
        var product = await context.Products.AsNoTracking().SingleOrDefaultAsync(a=> a.Id == id, cancellationToken);

        if (product == null) return NotFound(); 

        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody]Product product, CancellationToken cancellationToken)
    {
        await context.Products.AddAsync(product, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);

        return CreatedAtAction( 
                                nameof(GetProduct),              // Action name
                                new { id = product.Id },         // Route values
                                product                          // Response body
                              );
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProduct(int id, Product product, CancellationToken cancellationToken)
    {
        var isExist = await context.Products.AnyAsync(a=> a.Id == id, cancellationToken);

        if (isExist == false) return NotFound(); 

        await context.SaveChangesAsync(cancellationToken);

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteProductAsync(int id, CancellationToken cancellationToken)
    {
        var product = await context.Products.SingleOrDefaultAsync(a=> a.Id == id, cancellationToken);

        if (product == null) return NotFound(); 


        context.Products.Remove(product);
        await context.SaveChangesAsync(cancellationToken);

        return NoContent();
    }

}