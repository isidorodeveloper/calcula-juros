using Softplan.CalculaJuros.Services.Interfaces.TaxaJuros;

namespace Softplan.CalculaJuros.Services.TaxaJuros
{
    internal class TaxaJurosService : ITaxaJurosService
    {
        public decimal ObterTaxaJuros(int? taxa = 1) => (decimal)taxa / 100;
    }
}
