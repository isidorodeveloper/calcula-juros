using Softplan.CalculaJuros.Domain.Entities.Juros;
using Softplan.CalculaJuros.Domain.Results;

namespace Softplan.CalculaJuros.Services.Interfaces.Juros
{
    public interface IJurosService
    {
        Retorno CalcularJurosComposto(JurosComposto input);
    }
}
