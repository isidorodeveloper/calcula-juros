using Softplan.CalculaJuros.AppServices.Dtos.Juros;

namespace Softplan.CalculaJuros.AppServices.Interfaces.Juros
{
    public interface IJurosAppService
    {
        decimal CalcularJurosComposto(JurosCompostoDto input);
    }
}
