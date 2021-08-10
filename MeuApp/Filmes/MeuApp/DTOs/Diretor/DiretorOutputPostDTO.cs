using System;

public class DiretorOutputPostDTO
{
    public long Id { get; private set; }
    public string Nome { get; private set; }

    public DiretorOutputPostDTO(long id, string nome)
    {
        if (nome == null){
           throw new ArgumentNullException("Nome não encontrado!");
        }
        Id = id;
        Nome = nome;
    }
}