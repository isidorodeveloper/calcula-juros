using Microsoft.AspNetCore.Mvc;
using Softplan.CalculaJuros.AppServices.Interfaces.TaxaJuros;
using System;

namespace Softplan.CalculaJuros.Api.Controllers.TaxaJuros
{
    [ApiController]
    [Route("v1/taxaJuros")]
    public class TaxaJurosController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IActionResult ObterTaxaJuros(
            [FromServices]ITaxaJurosAppService appService
        )
        {
            try
            {
                var result = appService.ObterTaxaJuros(1);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }
    }
}
