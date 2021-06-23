using System.Collections.Generic;
public class FilmeOutputGetAllDTO
{
    public ICollection<Filme> Filmes { get; set; }

    public FilmeOutputGetAllDTO(List<Filme> filme)
    {
        Filmes = filme;
    }
}