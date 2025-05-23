using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Itau.Api.Dtos;
using Desafio_Itau.Api.UseCases.CreateTransacao;
using Desafio_Itau.Api.UseCases.GetEstatistica;
using Desafio_Itau.Api.UseCases.ListAllTransacoes;
using desafio_itau_dotnet.UseCases.DeleteTransacao;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_Itau.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransacaoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll([FromServices] ListAllTransacoesUseCase useCase)
        {
            var response = useCase.Execute();
            return Ok(response);
        }

        [HttpGet("/estatistica")]
        public IActionResult GetEstatistica([FromServices] GetEstatisticaUseCase useCase)
        {
            var response = useCase.Execute();
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post([FromBody] TransacaoDto request, [FromServices] CreateTransacaoUseCase useCase)
        {
            useCase.Execute(request);
            return Created();
        }

        [HttpDelete]
        public IActionResult Delete([FromServices] DeleteTransacaoUseCase useCase)
        {
            useCase.Execute();
            return Ok();
        }
    }
}