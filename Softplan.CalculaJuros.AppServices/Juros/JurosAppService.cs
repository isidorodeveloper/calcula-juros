using AutoMapper;
using Softplan.CalculaJuros.AppServices.Dtos.Juros;
using Softplan.CalculaJuros.AppServices.Interfaces.Juros;
using Softplan.CalculaJuros.Domain.Entities.Juros;
using Softplan.CalculaJuros.Domain.Results;
using Softplan.CalculaJuros.Services.Interfaces.Juros;

namespace Softplan.CalculaJuros.AppServices.Juros
{
    public class JurosAppService : IJurosAppService
    {
        private readonly IJurosService _service;
        private readonly IMapper _mapper;
        public JurosAppService(IJurosService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Retorno CalcularJurosComposto(JurosCompostoDto input)
        {
            return _service.CalcularJurosComposto(_mapper.Map<JurosComposto>(input));
        }
    }
}
