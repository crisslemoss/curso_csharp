public class FilmeOutputGetIdDTO
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string NomeDoDiretor { get; set; }

    public FilmeOutputGetIdDTO(int id, string titulo, string nomeDoDiretor) {
        Id = id;
        Titulo = titulo;
        NomeDoDiretor = nomeDoDiretor;
    }
}