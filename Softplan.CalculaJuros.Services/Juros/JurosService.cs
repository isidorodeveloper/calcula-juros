using Softplan.CalculaJuros.Domain.Entities.Juros;
using Softplan.CalculaJuros.Domain.Results;
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

        public Retorno CalcularJurosComposto(JurosComposto input)
        {
            if (input.Invalid)
                return new Retorno(false, "Informações inválidas!", input.Notifications);
            else
            {
                var taxaJuros = _service.ObterTaxaJuros();
                decimal valorFinal = input.ValorInicial * (decimal)Math.Pow((double)(1 + taxaJuros), input.Tempo);

                return new Retorno(true, "Cálculo Realizado!", valorFinal.TruncateDecimal(2));
            }
        }
    }
}
