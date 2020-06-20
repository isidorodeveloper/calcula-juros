using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Softplan.CalculaJuros.CrossCutting
{
    public static class Bootstraper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.RegisterTypes(Services.IoC.Module.GetTypes());
            services.RegisterTypes(AppServices.IoC.Module.GetTypes());
        }

        private static void RegisterTypes(this IServiceCollection container, Dictionary<Type, Type> types)
        {
            foreach (var item in types)
                container.AddScoped(item.Key, item.Value);
        }
    }
}
