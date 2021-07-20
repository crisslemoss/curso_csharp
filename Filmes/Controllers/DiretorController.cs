using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class DiretorController : ControllerBase
{
    private readonly DiretorService _diretorService;

    public DiretorController(DiretorService diretorService)
    {
        _diretorService = diretorService;
    }

    /// <summary>
    /// Lista os diretores
    /// </summary>            
    /// <response code="200">Lista de diretor exibida</response>
    [HttpGet]
    public async Task<List<DiretorOutputGetAllDTO>> Get()
    {
        var diretores = await _diretorService.GetAll();

        var outputDTOList = new List<DiretorOutputGetAllDTO>();

        foreach (Diretor diretor in diretores)
        {
            outputDTOList.Add(new DiretorOutputGetAllDTO(diretor.Id, diretor.Nome));
        }

        return outputDTOList;
    }

    /// <summary>
    /// Busca um diretor por Id
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /diretor / {id}
    ///     {
    ///        "id": 1,
    ///     }
    ///
    /// </remarks>
    /// <param id="Id">Id do diretor</param>
    /// <returns>O diretor encontrato</returns>
    /// <response code="200">Diretor encontrado com sucesso</response>
    /// <response code="404">Diretor não encontrado!</response>
    [HttpGet("{id}")]
    public async Task<ActionResult<DiretorOutputGetIdDTO>> Get(long id)
    {
        var diretor = await _diretorService.GetById(id);

        var diretorOutputGetIdDTO = new DiretorOutputGetIdDTO(diretor.Id);

        return Ok(diretorOutputGetIdDTO);
    }

    /*
        /// <summary>
        /// Cria um diretor
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /diretor
        ///     {
        ///        "nome": "Martin Scorsese",
        ///     }
        ///
        /// </remarks>    
        /// <returns>O diretor criado</returns>
        /// <response code="200">Diretor foi criado com sucesso</response>    
        [HttpPost]
        public async Task<ActionResult<DiretorOutputPostDTO>> Post([FromBody] DiretorInputPostDTO diretorInputPostDTO)
        {
            var diretor = new Diretor(diretorInputPostDTO.Nome);
            _diretorService.Cria();

            await _context.SaveChangesAsync();

            var DiretorOutputDTO = new DiretorOutputPostDTO(diretor.Id, diretor.Nome);
            return Ok(DiretorOutputDTO);
        }


        /// <summary>
        /// Edita um diretor
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /diretor
        ///     {
        ///        "id": 1,
        ///        "nome": "Martin Scorsese",
        ///     }
        ///
        /// </remarks>
        /// <param name="id">Id do diretor </param>    
        /// <returns>O diretor criado</returns>
        /// <response code="200">Diretor foi criado com sucesso</response>
        /// <response code="500">Diretor não encontrado</response>
        [HttpPut("{id}")]
        public async Task<ActionResult<DiretorOutputPutDTO>> Put(long id, [FromBody] DiretorInputPutDTO diretorInputPutDTO)
        {
            var diretor = new Diretor(diretorInputPutDTO.Nome);
            diretor.Id = id;
            _context.Diretores.Update(diretor);
            await _context.SaveChangesAsync();

            var diretorOutputPutDTO = new DiretorOutputPutDTO(diretor.Nome);
            return Ok(diretorOutputPutDTO);
        }*/

    // DELETE api/diretores/{id}
    [HttpDelete("{id}")]
    public ActionResult Delete(long id)
    {
        _diretorService.Exlcui(id);

        return Ok();
    }
}