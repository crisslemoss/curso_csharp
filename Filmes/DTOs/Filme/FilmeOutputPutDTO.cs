public class FilmeOutputPutDTO
{
    public string Titulo { get; set; }
    public string Ano { get; set; }
    public string Genero { get; set; }
    public long DiretorId { get; set; }
    
    public FilmeOutputPutDTO(string titulo, string ano, string genero, long diretorId)
    {
        Titulo = titulo;
        Ano = ano;
        Genero = genero;
        DiretorId = diretorId;
    }
}