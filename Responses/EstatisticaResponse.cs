using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Itau.Api.Responses
{
    public class EstatisticaResponse
    {
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public decimal Avg { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
    }
}