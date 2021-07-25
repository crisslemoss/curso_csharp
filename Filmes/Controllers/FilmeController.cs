using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private readonly FilmeService _filmeService;

    public FilmeController(FilmeService filmeService)
    {
        _filmeService = filmeService;
    }


    /// <summary>
    /// Lista os filmes
    /// </summary>            
    /// <response code="200">Lista de filmes exibida</response>
    [HttpGet]

    public async Task<ActionResult<FilmeListOutputGetAllDTO>> Get(CancellationToken cancellationToken, int limit = 5, int page = 1)
    {
        return await _filmeService.GetByPageAsync(limit, page, cancellationToken);
    }



    /// <summary>
    /// Busca um filme por Id
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /filme / {id}
    ///     {
    ///        "id": 1,
    ///     }
    ///
    /// </remarks>
    /// <param name="id">Id do filme a ser buscado</param>
    /// <response code="200">Filme encontrado com sucesso</response>     
    /// <response code="403">Você não tem permissão de acesso nesse servidor.</response>
    /// <response code="404">Não foram encontrados registros.</response>
    /// <response code="500">A solicitação não foi concluída devido a um erro interno no lado do servidor.</response>
    [HttpGet("{id}")]
    public async Task<ActionResult<FilmeOutputGetAllDTO>> GetById(int id)
    {
        var filme = await _filmeService.BuscaId(id);

        var outputDTO = new FilmeOutputGetIdDTO(filme.Id, filme.Titulo, filme.Diretor.Nome);
        return Ok(outputDTO);
    }

    /// <summary>
    /// Cria um filme
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /filme
    ///     {
    ///         "titulo": "Silencio",
    ///         "ano": "2016",
    ///         "genero": "Drama",
    ///         "diretorId": 1
    ///     }
    ///
    /// </remarks>    
    /// <returns>O filme criado</returns>
    /// <response code="200">Filme foi criado com sucesso</response>        
    [HttpPost]
    public async Task<ActionResult<FilmeOutputPostDTO>> Post([FromBody] FilmeInputPostDTO filmeInputDTO)
    {
        var filme = await _filmeService.Cria(new Filme(filmeInputDTO.Titulo, filmeInputDTO.DiretorId));

        var outputDTO = new FilmeOutputPostDTO(filme.Id, filme.Titulo);

        return Ok(outputDTO);
    }

    /// <summary>
    /// Edita um filme
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /filme
    ///     {
    ///         "titulo": "Silencio",
    ///         "ano": "2016",
    ///         "genero": "Drama",
    ///         "diretorId": 1
    ///     }
    ///
    /// </remarks>
    /// <param name="id">Id do filme </param>
    /// <param name="filmeInputPutDTO"></param>    
    /// <returns>O filme criado</returns>
    /// <response code="200">Filme foi criado com sucesso</response>
    /// <response code="500">Filme não encontrado</response>
    [HttpPut("{id}")]
    public async Task<ActionResult<FilmeOutputPutDTO>> Put(int id, [FromBody] FilmeInputPutDTO filmeInputPutDTO)
    {
        var filme = new Filme(filmeInputPutDTO.Titulo, filmeInputPutDTO.DiretorId);

        await _filmeService.Atualiza(filme, filme.Id);

        var outputDTO = new FilmeOutputPutDTO(filme.Titulo, filme.Ano, filme.Genero, filme.DiretorId);
        return Ok(outputDTO);
    }


    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _filmeService.Exclui(id);

        return Ok();
    }
}