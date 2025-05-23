using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Itau.Api.Responses;
using desafio_itau_dotnet.Data;

namespace Desafio_Itau.Api.UseCases.ListAllTransacoes
{
    public class ListAllTransacoesUseCase
    {
        private readonly TransacaoInMemoryManager _transacaoInMemoryManager;
        public ListAllTransacoesUseCase(TransacaoInMemoryManager transacaoInMemoryManager)
        {
            _transacaoInMemoryManager = transacaoInMemoryManager;
        }

        public ListAllTransacoesResponse Execute()
        {
            var data = _transacaoInMemoryManager.GetAll();
            var response = data.Select(x => new TransacaoResponse { Valor = x.Valor, DataHora = x.DataHora.ToLocalTime().ToString() });

            return new ListAllTransacoesResponse
            {
                Transacoes = [.. response]
            };
        }
    }
}