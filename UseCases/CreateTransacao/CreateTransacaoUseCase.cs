using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Itau.Api.Dtos;
using Desafio_Itau.Api.Exceptions;
using Desafio_Itau.Api.UseCases.CreateTransacaoUseCase;
using desafio_itau_dotnet.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_Itau.Api.UseCases.CreateTransacao
{
    public class CreateTransacaoUseCase
    {
        private readonly TransacaoInMemoryManager _transacaoInMemoryManager;
        public CreateTransacaoUseCase(TransacaoInMemoryManager transacaoInMemoryManager)
        {
            _transacaoInMemoryManager = transacaoInMemoryManager;
        }
        public void Execute(TransacaoDto request)
        {
            if (request is null)
            {
                throw new BadRequestException("Transação inválida.");
            }
            request.DataHora = request.DataHora.ToUniversalTime();

            Validate(request);

            _transacaoInMemoryManager.Add(request);

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