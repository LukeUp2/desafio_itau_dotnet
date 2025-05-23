using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_itau_dotnet.Data;

namespace desafio_itau_dotnet.UseCases.DeleteTransacao
{
    public class DeleteTransacaoUseCase
    {
        private readonly TransacaoInMemoryManager _transacaoInMemoryManager;
        public DeleteTransacaoUseCase(TransacaoInMemoryManager transacaoInMemoryManager)
        {
            _transacaoInMemoryManager = transacaoInMemoryManager;
        }

        public void Execute()
        {
            _transacaoInMemoryManager.DeleteAll();
        }
    }
}