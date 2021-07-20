using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class DiretorService : IDiretorService
{
    private readonly ApplicationDbContext _context;

    private readonly IDiretorService _diretorService;

    public DiretorService(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Diretor> Atualiza(Diretor diretor, long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<Diretor> Cria(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task Exlcui(long id)
    {
        throw new System.NotImplementedException();
    }
    public Task<Diretor> GetById(long id)
    {
        throw new System.NotImplementedException();
    }

    public async Task<List<Diretor>> GetAll()
    {
        var diretores = await _context.Diretores.ToListAsync();

        if (!diretores.Any())
        {
            throw new System.Exception("Não existem diretores cadastrados!");
        }

        return diretores;
    }
}