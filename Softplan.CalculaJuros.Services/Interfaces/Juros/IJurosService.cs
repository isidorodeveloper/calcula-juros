using Softplan.CalculaJuros.Domain.Entities.Juros;

namespace Softplan.CalculaJuros.Services.Interfaces.Juros
{
    public interface IJurosService
    {
        decimal CalcularJurosComposto(JurosComposto input);
    }
}
