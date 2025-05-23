using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Itau.Api.Dtos;

namespace desafio_itau_dotnet.Data
{
    public class TransacaoInMemoryManager
    {
        private readonly List<TransacaoDto> _transacoes = [];

        public List<TransacaoDto> GetAll()
        {
            return _transacoes;
        }

        public List<TransacaoDto> GetTransacoesLastMinute()
        {
            return _transacoes.Where(t => t.DataHora >= DateTime.UtcNow.AddSeconds(-60)).ToList();
        }

        public void Add(TransacaoDto transacao)
        {
            _transacoes.Add(transacao);
        }

        public void DeleteAll()
        {
            _transacoes.Clear();
        }
    }
}