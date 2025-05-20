using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Itau.Api.Dtos
{
    public class TransacaoDto
    {
        public decimal Valor { get; set; }
        public DateTime DataHora { get; set; }
    }
}