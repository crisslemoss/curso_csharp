public class Filme
{
    public Filme(string titulo)
    {
        Titulo = titulo;
    }

    public Filme(string titulo, long diretorId)
    {
        Titulo = titulo;
        DiretorId = diretorId;
    }

    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Ano { get; set; }
    public string Genero { get; set; }
    public long DiretorId { get; set; }
    public Diretor Diretor { get; set; }
}