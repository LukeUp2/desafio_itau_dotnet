using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Itau.Api.Dtos;
using Desafio_Itau.Api.Exceptions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_Itau.Api.UseCases.CreateTransacaoUseCase
{
    public class CreateTransacaoUseCase
    {
        public void Execute(TransacaoDto request)
        {
            if (request is null)
            {
                throw new BadRequestException("Transação inválida.");
            }
            Validate(request);
        }

        private void Validate(TransacaoDto request)
        {
            var result = new CreateTransacaoUseCaseValidator().Validate(request);

            if (result.IsValid == false)
            {
                throw new ErrorOnValidationException(result.Errors.Select(x => x.ErrorMessage).ToList());
            }
        }
    }
}