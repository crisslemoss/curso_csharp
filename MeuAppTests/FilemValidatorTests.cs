using System;
using Xunit;
using FluentValidation.TestHelper;

namespace MeuAppTests
{
    public class FilmeValidatorTests
    {
        [Fact]
        public void NomeDoFilmeDeveApresentarErroSeForNull()
        {
            var validator = new FilmeInputPostDTOValidator();
            var dto = new FilmeInputPostDTO { Nome = null };
            var result = validator.TestValidate(dto);
            result.ShouldHaveValidationErrorFor(filme => filme.Nome);
        }

        [Fact]
        public void NomeDoFilmeDeveApresentarErroSeForVazio()
        {
            var validator = new FilmeInputPostDTOValidator();
            var dto = new FilmeInputPostDTO { Nome = "" };
            var result = validator.TestValidate(dto);
            result.ShouldHaveValidationErrorFor(filme => filme.Nome);
        }

        [Theory]
        [InlineData("Teste")]
        [InlineData("Teste Teste Teste Teste")]
        public void NomeDoFilmeValidoNaoDeveConterErro(string data)
        {
            var validator = new FilmeInputPostDTOValidator();
            var dto = new FilmeInputPostDTO { Nome = data };
            var result = validator.TestValidate(dto);
            result.ShouldNotHaveValidationErrorFor(filme => filme.Nome);
        }
    }
}
