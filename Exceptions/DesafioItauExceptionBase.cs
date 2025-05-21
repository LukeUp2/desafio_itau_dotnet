using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Itau.Api.Exceptions
{
    public class DesafioItauExceptionBase : Exception
    {
        public DesafioItauExceptionBase(string message) : base(message)
        {

        }
    }
}