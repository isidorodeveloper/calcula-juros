using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Softplan.CalculaJuros.AppServices.Dtos.Juros;
using Softplan.CalculaJuros.AppServices.Interfaces.Juros;
using System;

namespace Softplan.CalculaJuros.Api.Controllers.Juros
{
    [Route("v1/calculaJuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IJurosAppService _appService;
        public CalculaJurosController(IJurosAppService appService)
        {
            _appService = appService;
        }

        [Route("")]
        [HttpGet]
        public IActionResult CalcularJurosComposto(
            [FromQuery] JurosCompostoDto input
        )
        {
            try
            {
                var result = _appService.CalcularJurosComposto(input);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }

        [Route("showmethecode")]
        [HttpGet]
        public string ObterUrlGitHub(
            [FromServices]IConfiguration config
        )
        {
            return config.GetSection("Repositorio_GitHub:Url").Value;
        }
    }
}
