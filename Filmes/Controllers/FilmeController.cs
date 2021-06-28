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
    public async Task<ActionResult<FilmeOutputGetIdDTO>> Get(int id)
    {
        var filme = await _context.Filmes.FirstOrDefaultAsync(filme => filme.Id == id);
        if (filme == null)
        {
            return Conflict("Filme nao cadastrado!");
        }
         
        var diretor = await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == filme.DiretorId);

        var filmeOutPutGetId = new FilmeOutputGetIdDTO(filme.Titulo, filme.Ano, filme.Genero, diretor.Nome);
        return Ok(filmeOutPutGetId);
    }    
   
    [HttpPost]
    public async Task<ActionResult<FilmeOutputPostDTO>> Post([FromBody] FilmeInputPostDTO  filmeInputDTO)
    {
        var diretor = await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == filmeInputDTO.DiretorId);
        if (diretor == null)
        {
            return NotFound("Diretor não encontrado!");            
        }

        var filme = new Filme(filmeInputDTO.Titulo, filmeInputDTO.DiretorId);
        _context.Filmes.Add(filme);

        await _context.SaveChangesAsync();

        var filmeOutputDTO = new FilmeOutputPostDTO(filme.Id, filme.Titulo); 
        return Ok(filmeOutputDTO);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<FilmeOutputPutDTO>> Put(int id, [FromBody] FilmeInputPutDTO filmeInputPutDTO)
    {
        var diretor = await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == filmeInputPutDTO.DiretorId);
        if (diretor == null)
        {
            return NotFound("Id diretor invalido!");            
        }

        var filme = new Filme(filmeInputPutDTO.Titulo, filmeInputPutDTO.DiretorId);
        filme.Id = id;
        _context.Filmes.Update(filme);
        await _context.SaveChangesAsync();

        var filmeOutputPutDTO = new FilmeOutputPutDTO(filme.Titulo, filme.Ano, filme.Genero, filme.DiretorId);
        return Ok(filmeOutputPutDTO);
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