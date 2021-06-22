using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class DiretorController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public DiretorController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET api/diretores
    [HttpGet]
    public async Task<List<Diretor>> Get()
    {
        return await _context.Diretores.ToListAsync();
    }

    // GET api/diretores/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Diretor>> Get(long id)
    {
        var diretor = await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == id);
        return Ok(diretor);
    }

    // POST api/diretores
    [HttpPost]
    public async Task<ActionResult<DiretorOutputPostDTO>> Post([FromBody] DiretorInputPostDTO diretorInputPostDTO)
    {
        var diretor = new Diretor(diretorInputPostDTO.Nome);
        _context.Diretores.Add(diretor);
        await _context.SaveChangesAsync();

        var DiretorOutputDTO = new DiretorOutputPostDTO(diretor.Id, diretor.Nome);
        return Ok(DiretorOutputDTO);
    }

    // PUT api/diretores/{id}
    [HttpPut("{id}")]
    public async Task<ActionResult<DiretorOutputPutDTO>> Put(long id, [FromBody] DiretorInputPutDTO diretorInputPutDTO)
    {
        var diretor = new Diretor(diretorInputPutDTO.Nome);
        diretor.Id = id;
        _context.Diretores.Update(diretor);
        await _context.SaveChangesAsync();

        var diretorOutputPutDTO = new DiretorOutputPutDTO(diretor.Nome);
        return Ok(diretorOutputPutDTO);
    }

    // DELETE api/diretores/{id}
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(long id)
    {
        var diretor = await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == id);
        _context.Remove(diretor);
        await _context.SaveChangesAsync();
        return Ok(diretor);
    }
}