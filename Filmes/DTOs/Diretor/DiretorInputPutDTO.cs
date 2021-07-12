using FluentValidation;
public class DiretorInputPutDTO
{
    public long Id { get; set; }
    public string Nome { get; set; }
}


public class DiretorInputPutDTOValidator : AbstractValidator<DiretorInputPutDTO>
{
    public DiretorInputPutDTOValidator()
    {
        RuleFor(diretor => diretor.Id).NotNull();
        RuleFor(diretor => diretor.Nome).NotNull();
        RuleFor(diretor => diretor.Nome).Length(2, 250).WithMessage("Tamanho {TotalLength} inválido");
    }
}
