using FluentValidation;
public class FilmeInputPostDTO
{
    public string Titulo { get; set; }
    public string Ano { get; set; }
    public string Genero { get; set; }
    public long DiretorId { get; set; }

    public FilmeInputPostDTO(string titulo, string ano, string genero, long diretorId)
    {
        Titulo = titulo;
        Ano = ano;
        Genero = genero;
        DiretorId = diretorId;
    }
}

public class FilmeInputPostDTOValidator : AbstractValidator<FilmeInputPostDTO>
{
    public FilmeInputPostDTOValidator()
    {
        RuleFor(filme => filme.Titulo).Length(2, 250).WithMessage("Tamanho {TotalLength} inválido");
        RuleFor(filme => filme.Ano).Length(4).WithMessage("Tamanho {TotalLength} para o ano é inválido");
        RuleFor(filme => filme.DiretorId).NotNull();
    }
}
