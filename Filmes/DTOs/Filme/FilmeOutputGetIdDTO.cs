public class FilmeOutputGetIdDTO
{
    public string Titulo { get; set; }
    public string Ano { get; set; }
    public string Genero { get; set; }
    public string Diretor { get; set; }

    public FilmeOutputGetIdDTO(string ano, string titulo, string genero, string diretor)
    {
        Titulo = titulo;
        Ano = ano;
        Genero = genero;
        Diretor = diretor;
    }
}