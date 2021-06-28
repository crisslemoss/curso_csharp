public class FilmeOutputGetAllDTO
{
    public int Id {get; set;}
    public string Titulo {get; set;}

    public FilmeOutputGetAllDTO(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
    }
}