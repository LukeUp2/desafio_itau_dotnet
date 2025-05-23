using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Itau.Api.Responses
{
    public class ListAllTransacoesResponse
    {
        public List<TransacaoResponse> Transacoes { get; set; } = [];
    }
}