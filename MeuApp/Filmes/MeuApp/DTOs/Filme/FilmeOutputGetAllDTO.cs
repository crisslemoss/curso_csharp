
using System.Collections.Generic;

public class FilmeListOutputGetAllDTO
{
    public int CurrentPage { get; init; }

    public int TotalItems { get; init; }

    public int TotalPages { get; init; }

    public List<FilmeOutputGetAllDTO> Items { get; init; }
}

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