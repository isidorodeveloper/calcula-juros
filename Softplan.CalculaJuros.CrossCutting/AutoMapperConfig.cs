using AutoMapper;
using System.Collections.Generic;

namespace Softplan.CalculaJuros.CrossCutting
{
    public static class AutoMapperConfig
    {
        public static IEnumerable<Profile> GetAutoMapperProfiles()
        {
            var result = new List<Profile>();

            result.Add(new AppServices.Mappings.MappingProfile());

            return result;
        }
    }
}
