public class FilmeOutputGetAllDTO
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Ano { get; set; }
    public string Genero { get; set; }

    public FilmeOutputGetAllDTO(int id, string titulo, string ano, string genero)
    {
        Id = id;
        Titulo = titulo;
        Ano = ano;
        Genero = genero;
    }
}