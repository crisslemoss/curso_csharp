using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class FilmeService : IFilmeService
{
    private readonly ApplicationDbContext _context;
    public FilmeService(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Filme> Atualiza(Filme filme)
    {
        throw new System.NotImplementedException();
    }

    public Task<Filme> BuscaId(int id)
    {
        throw new System.NotImplementedException();
    }

    public Task<List<Filme>> Buscatodos()
    {
        throw new System.NotImplementedException();
    }

    public Task<long> Cria(Filme filme)
    {
        throw new System.NotImplementedException();
    }

    public async Task Exclui(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        _context.Remove(filme);
        await _context.SaveChangesAsync();
    }
}