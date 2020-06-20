using Softplan.CalculaJuros.Domain.Interfaces.Repositories;
using System;

namespace Softplan.CalculaJuros.Infra.Repositories
{
    public class CalculaJurosRepository : ICalculaJurosRepository
    {
        public decimal ObterTaxaJuros(int taxa) => Convert.ToDecimal(taxa / 100);
    }
}
