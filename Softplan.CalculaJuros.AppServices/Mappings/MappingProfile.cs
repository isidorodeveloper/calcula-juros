using AutoMapper;
using Softplan.CalculaJuros.AppServices.Dtos.Juros;
using Softplan.CalculaJuros.Domain.Entities.Juros;

namespace Softplan.CalculaJuros.AppServices.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Juros
            CreateMap<JurosComposto, JurosCompostoDto>().ReverseMap();
            #endregion
        }
    }
}
