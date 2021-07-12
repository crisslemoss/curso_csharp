using FluentValidation;
public class FilmeInputPutDTO
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Ano { get; set; }
    public string Genero { get; set; }
    public long DiretorId { get; set; }
}

public class FilmeInputPutDTOValidator : AbstractValidator<FilmeInputPutDTO>
{
    public FilmeInputPutDTOValidator()
    {
        RuleFor(filme => filme.Id).NotNull();
        RuleFor(filme => filme.Titulo).NotNull();
        RuleFor(filme => filme.Titulo).Length(2, 250).WithMessage("Tamanho {TotalLength} inválido");
        RuleFor(filme => filme.Ano).Length(4).WithMessage("Tamanho {TotalLength} inválido");
        RuleFor(filme => filme.DiretorId).NotNull();
    }
}
