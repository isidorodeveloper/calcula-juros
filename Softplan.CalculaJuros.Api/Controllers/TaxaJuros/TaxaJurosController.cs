using Microsoft.AspNetCore.Mvc;
using Softplan.CalculaJuros.AppServices.Interfaces.TaxaJuros;
using System;

namespace Softplan.CalculaJuros.Api.Controllers.TaxaJuros
{
    [ApiController]
    [Route("v1/taxaJuros")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosAppService _appService;
        public TaxaJurosController(ITaxaJurosAppService appService)
        {
            _appService = appService;
        }

        [Route("")]
        [HttpGet]
        public IActionResult ObterTaxaJuros()
        {
            try
            {
                var result = _appService.ObterTaxaJuros(1);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }
    }
}
