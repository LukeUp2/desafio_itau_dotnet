using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Itau.Api.Exceptions
{
    public class ErrorOnValidationException : DesafioItauExceptionBase
    {
        public IList<string> ErrorMessages { get; set; }
        public ErrorOnValidationException(IList<string> errorsMessages) : base(string.Empty)
        {
            ErrorMessages = errorsMessages;
        }
    }
}