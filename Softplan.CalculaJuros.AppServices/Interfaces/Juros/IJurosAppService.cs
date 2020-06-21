using Softplan.CalculaJuros.AppServices.Dtos.Juros;
using Softplan.CalculaJuros.Domain.Results;

namespace Softplan.CalculaJuros.AppServices.Interfaces.Juros
{
    public interface IJurosAppService
    {
        Retorno CalcularJurosComposto(JurosCompostoDto input);
    }
}
