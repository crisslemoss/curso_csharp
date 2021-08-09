using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public interface IFilmeService
{
    Task<FilmeListOutputGetAllDTO> GetByPageAsync(int limit, int page, CancellationToken cancellationToken);
    Task<Filme> BuscaId(int id);
    Task<Filme> Cria(Filme filme);
    Task<Filme> Atualiza(Filme filme, int id);
    Task Exclui(int id);
}