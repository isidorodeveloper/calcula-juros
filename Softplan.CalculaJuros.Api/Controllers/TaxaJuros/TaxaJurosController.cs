using Microsoft.AspNetCore.Mvc;
using Softplan.CalculaJuros.AppServices.Interfaces.TaxaJuros;

namespace Softplan.CalculaJuros.Api.Controllers.TaxaJuros
{
    [ApiController]
    [Route("v1/taxaJuros")]
    public class TaxaJurosController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public decimal ObterTaxaJuros(
            [FromServices]ITaxaJurosAppService appService
        )
        {
            return appService.ObterTaxaJuros(1);
        }
    }
}
