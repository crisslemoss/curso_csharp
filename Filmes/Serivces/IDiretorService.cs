using System.Collections.Generic;
using System.Threading.Tasks;

public interface IDiretorService
{
    Task<List<Diretor>> GetAll();
    Task<Diretor> GetById(long id);
    Task<Diretor> Cria(long id);
    Task<Diretor> Atualiza(Diretor diretor, long id);
    Task Exlcui(long id);
}