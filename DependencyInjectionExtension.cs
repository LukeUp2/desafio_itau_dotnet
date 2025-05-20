using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Itau.Api.UseCases.CreateTransacaoUseCase;

namespace Desafio_Itau.Api
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplicationExtension(this IServiceCollection services)
        {
            AddUseCases(services);
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<CreateTransacaoUseCase>();
        }
    }
}