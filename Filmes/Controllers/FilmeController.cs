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
    public async Task<ActionResult<FilmeOutputGetAllDTO>> Get()
    {
        var filme = await _context.Filmes.ToListAsync();
        var filmeOutputGetAllDTO = new FilmeOutputGetAllDTO(filme);

        return filmeOutputGetAllDTO;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Filme>> Get(int id)
    {
        var filme = await _context.Filmes.FirstOrDefaultAsync(filme => filme.Id == id);
        if (filme == null)
        {
            return Conflict("Filme nao cadastrado!");
        }
        return Ok(filme);
    }

    // POST api/filmes
    [HttpPost]
    public async Task<ActionResult<Filme>> Post([FromBody] Filme filme)
    {
        _context.Filmes.Add(filme);
        await _context.SaveChangesAsync();

        return Ok(filme);
    }


    [HttpPut("{id}")]
    public async Task<ActionResult<Filme>> Put(int id, [FromBody] Filme filme)
    {
        filme.Id = id;
        _context.Filmes.Update(filme);
        await _context.SaveChangesAsync();

        return Ok(filme);
    }
    /*
        [HttpPut("{id}")]
        public async Task<ActionResult<FilmeOutputPutDTO>> Put(int id, [FromBody] FilmeInputPutDTO filmeInputPutDTO)
        {
            var filme = new Filme(filmeInputPutDTO.Titulo);
            filme.Id = id;
            _context.Filmes.Update(filme);
            await _context.SaveChangesAsync();

            var filmeOutputPutDTO = new FilmeOutputPutDTO(filme.Titulo, filme.Ano, filme.Genero, filme.DiretorId);
            return Ok(filmeOutputPutDTO);
        }
    */

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        _context.Remove(filme);
        _context.SaveChangesAsync();
        return Ok();
    }
}