using System.Collections.Generic;
public class DiretorOutputGetAllDTO
{
    public ICollection<Diretor> Diretores { get; set; }

    public DiretorOutputGetAllDTO(List<Diretor> diretor)
    {
        Diretores = diretor;
    }
}