using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Itau.Api.Responses;
using desafio_itau_dotnet.Data;

namespace Desafio_Itau.Api.UseCases.GetEstatistica
{
    public class GetEstatisticaUseCase
    {
        private readonly TransacaoInMemoryManager _transacaoInMemoryManager;
        public GetEstatisticaUseCase(TransacaoInMemoryManager transacaoInMemoryManager)
        {
            _transacaoInMemoryManager = transacaoInMemoryManager;
        }

        public EstatisticaResponse Execute()
        {
            var lastTransacoes = _transacaoInMemoryManager.GetTransacoesLastMinute();
            if (lastTransacoes.Count == 0)
            {
                return new EstatisticaResponse
                {
                    Count = 0,
                    Avg = 0,
                    Max = 0,
                    Min = 0
                };
            }

            var count = lastTransacoes.Count;
            var sum = lastTransacoes.Sum(x => x.Valor);

            var response = new EstatisticaResponse
            {
                Count = count,
                Sum = sum,
                Avg = sum / count,
                Max = lastTransacoes.Max(x => x.Valor),
                Min = lastTransacoes.Min(x => x.Valor)
            };

            return response;
        }
    }
}