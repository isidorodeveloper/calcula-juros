using Softplan.CalculaJuros.AppServices.Interfaces.TaxaJuros;
using Softplan.CalculaJuros.Services.Interfaces.TaxaJuros;

namespace Softplan.CalculaJuros.AppServices.TaxaJuros
{
    public class TaxaJurosAppService : ITaxaJurosAppService
    {
        private readonly ITaxaJurosService _service;
        public TaxaJurosAppService(ITaxaJurosService service)
        {
            _service = service;
        }
        public decimal ObterTaxaJuros(int taxa)
        {
            return _service.ObterTaxaJuros(taxa);
        }
    }
}
