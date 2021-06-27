public class FilmeOutputPostDTO
{   
    public int  Id { get; set; }
    public string Titulo { get; set; }    

    public FilmeOutputPostDTO(int id, string titulo)
    {                
        Id = id;
        Titulo = titulo;
    }
}

/*
public class FilmeOutputPostDTO
{   
    public int  Id { get; set; }
    public string Titulo { get; set; }
    public string Ano { get; set; }
    public string Genero { get; set; }    
    public long DiretorId { get; set; }

    public FilmeOutputPostDTO(int id, string titulo, string ano, string genero, long diretorId)
    {                
        Id = id;
        Titulo = titulo;
        Ano = ano;
        Genero = genero;        
        DiretorId = diretorId;
    }
}
*/
