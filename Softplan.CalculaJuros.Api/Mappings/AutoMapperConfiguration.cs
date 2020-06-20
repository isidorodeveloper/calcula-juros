using AutoMapper;

namespace Softplan.CalculaJuros.Api.Mappings
{
    public static class AutoMapperConfiguration
    {
        public static IMapper Register()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfiles(CrossCutting.AutoMapperConfig.GetAutoMapperProfiles());
            });

            return config.CreateMapper();
        }
    }
}
