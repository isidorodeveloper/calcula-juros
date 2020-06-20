using Microsoft.Extensions.DependencyInjection;

namespace Softplan.CalculaJuros.Api.IoC
{
    public static class IoCConfiguration
    {
        public static void Register(IServiceCollection services)
        {
            CrossCutting.Bootstraper.RegisterServices(services);
        }
    }
}
