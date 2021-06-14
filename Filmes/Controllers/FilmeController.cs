using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public FilmeController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<List<Filme>> Get()
    {
        return await _context.Filmes.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Filme>> Post([FromBody] Filme filme)
    {
        _context.Filmes.Add(filme);
        await _context.SaveChangesAsync();

        return Ok(filme);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        _context.Remove(filme);
        _context.SaveChangesAsync();
        return Ok();
    }
}