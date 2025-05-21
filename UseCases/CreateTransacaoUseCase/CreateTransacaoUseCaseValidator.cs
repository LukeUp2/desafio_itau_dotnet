using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Itau.Api.Dtos;
using FluentValidation;

namespace Desafio_Itau.Api.UseCases.CreateTransacaoUseCase
{
    public class CreateTransacaoUseCaseValidator : AbstractValidator<TransacaoDto>
    {
        public CreateTransacaoUseCaseValidator()
        {
            RuleFor(x => x.Valor).GreaterThanOrEqualTo(0).WithMessage("O valor da transação deve ser maior ou igual a 0.");
            RuleFor(x => x.DataHora).GreaterThan(DateTime.Now).WithMessage("A transação não pode ocorrer no futuro.");
        }
    }
}