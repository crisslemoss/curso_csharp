
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private readonly FilmeServico _filmeServico;

    public FilmeController(FilmeServico filmeServico)
    {
        _filmeServico = filmeServico;
    }

    /// <summary>
    /// Lista os filmes
    /// </summary>            
    /// <response code="200">Lista de filmes exibida</response>
    [HttpGet]
    public async Task<List<FilmeOutputGetAllDTO>> Get()
    {
        var filmes = await _filmeServico.Buscatodos();

        if (!filmes.Any())
        {
            NotFound("Não existem diretores cadastrados!");
        }

        var outputDTOList = new List<FilmeOutputGetAllDTO>();

        foreach (Filme filme in filmes)
        {
            outputDTOList.Add(new FilmeOutputGetAllDTO(filme.Id, filme.Titulo, filme.Ano, filme.Genero));
        }

        return outputDTOList;
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
    public async Task<ActionResult<FilmeOutputGetAllDTO>> Get(int id)
    {
        var filme = await _filmeServico.BuscaId(id);

        if (filme == null)
        {
            throw new ArgumentNullException("Filme não encontrado!");
        }

        var outputDTO = new FilmeOutputGetIdDTO(filme.Id, filme.Titulo, filme.Diretor.Nome);
        return Ok(outputDTO);
    }
    /*
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
            var diretor = await _filmeServico.Cria
            var diretor = await _filmeServico.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == filmeInputDTO.DiretorId);

            var diretor = await _filmeServico.Cria(FilmeInputPostDTO filmeInputDTO);

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
        /// <returns>O filme criado</returns>
        /// <response code="200">Filme foi criado com sucesso</response>
        /// <response code="500">Filme não encontrado</response>
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
    */
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        _filmeServico.Exclui(id);

        return Ok();
    }
}