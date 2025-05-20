using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Itau.Api.Dtos;
using Desafio_Itau.Api.UseCases.CreateTransacaoUseCase;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_Itau.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransacaoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] TransacaoDto request, [FromServices] CreateTransacaoUseCase useCase)
        {
            useCase.Execute(request);
            return Created();
        }
    }
}