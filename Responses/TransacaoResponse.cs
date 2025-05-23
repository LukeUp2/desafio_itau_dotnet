using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Itau.Api.Responses
{
    public class TransacaoResponse
    {
        public decimal Valor { get; set; }
        public string DataHora { get; set; } = string.Empty;
    }
}