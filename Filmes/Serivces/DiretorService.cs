public class DiretorServico
{
    private readonly ApplicationDbContext _context;
    public DiretorServico(ApplicationDbContext context)
    {
        _context = context;
    }
}