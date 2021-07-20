using System.Collections.Generic;
using System.Threading.Tasks;

public interface IFilmeService
{
    Task<List<Filme>> Buscatodos();
    Task<Filme> BuscaId(int id);
    Task<long> Cria(Filme filme);
    Task<Filme> Atualiza(Filme filme);
    Task Exclui(int id);
}