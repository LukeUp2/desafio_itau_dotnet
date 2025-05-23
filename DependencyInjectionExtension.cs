using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Itau.Api.UseCases.CreateTransacao;
using Desafio_Itau.Api.UseCases.GetEstatistica;
using Desafio_Itau.Api.UseCases.ListAllTransacoes;
using desafio_itau_dotnet.Data;
using desafio_itau_dotnet.UseCases.DeleteTransacao;

namespace Desafio_Itau.Api
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplicationExtension(this IServiceCollection services)
        {
            AddUseCases(services);
            AddInMemoryObject(services);
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<CreateTransacaoUseCase>();
            services.AddScoped<DeleteTransacaoUseCase>();
            services.AddScoped<ListAllTransacoesUseCase>();
            services.AddScoped<GetEstatisticaUseCase>();
        }

        private static void AddInMemoryObject(IServiceCollection services)
        {
            services.AddSingleton<TransacaoInMemoryManager>();
        }
    }
}