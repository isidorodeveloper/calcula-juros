using Softplan.CalculaJuros.Domain.Entities.Juros;
using Softplan.CalculaJuros.Services.Interfaces.Juros;
using Softplan.CalculaJuros.Services.Interfaces.TaxaJuros;
using Softplan.CalculaJuros.Utils.Helpers;
using System;

namespace Softplan.CalculaJuros.Services.Juros
{
    internal class JurosService : IJurosService
    {
        private readonly ITaxaJurosService _service;
        public JurosService(ITaxaJurosService service)
        {
            _service = service;
        }

        public decimal CalcularJurosComposto(JurosComposto input)
        {
            var taxaJuros = _service.ObterTaxaJuros(2);
            decimal valorFinal = input.ValorInicial * (decimal)Math.Pow((double)(1 + taxaJuros), input.Tempo);

            return valorFinal.TruncateDecimal(2);
        }
    }
}
