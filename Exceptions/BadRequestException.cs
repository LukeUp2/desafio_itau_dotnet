using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Itau.Api.Exceptions
{
    public class BadRequestException : DesafioItauExceptionBase
    {
        public string ErrorMessage { get; set; }
        public BadRequestException(string message) : base(message)
        {
            ErrorMessage = message;
        }
    }
}