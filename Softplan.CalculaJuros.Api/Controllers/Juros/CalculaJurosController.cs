using Microsoft.AspNetCore.Mvc;
using Softplan.CalculaJuros.AppServices.Dtos.Juros;
using Softplan.CalculaJuros.AppServices.Interfaces.Juros;

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
        public decimal CalcularJurosComposto([FromQuery] JurosCompostoDto input)
        {
            return _appService.CalcularJurosComposto(input);
        }
    }
}
