using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Softplan.CalculaJuros.Api.Controllers.Juros;
using Softplan.CalculaJuros.AppServices.Dtos.Juros;
using Softplan.CalculaJuros.AppServices.Interfaces.Juros;
using Softplan.CalculaJuros.Domain.Results;

namespace Softplan.CalculaJuros.Tests.Api.Juros
{
    [TestClass]
    public class CalculaJurosControllerTests
    {
        private Mock<IJurosAppService> _validAppService;
        private Mock<IJurosAppService> _invalidAppService;
        private readonly CalculaJurosController _validController;
        private readonly CalculaJurosController _invalidController;
        private ObjectResult _retorno;
        private JurosCompostoDto _validInput = new JurosCompostoDto { ValorInicial = 100, Tempo = 5 };
        private JurosCompostoDto _invalidInput = new JurosCompostoDto();
        private Retorno _validRetorno = new Retorno { Success = true, Message = "Cálculo Realizado!", Data = 105.10m };
        private Retorno _invalidRetorno = new Retorno { Success = false, Message = "Informações inválidas!", Data = null };

        public CalculaJurosControllerTests()
        {
            ConfigurarAppSerice();
            _validController = new CalculaJurosController(_validAppService.Object);
            _invalidController = new CalculaJurosController(_invalidAppService.Object);
        }

        private void ConfigurarAppSerice()
        {
            _validAppService = new Mock<IJurosAppService>();
            _invalidAppService = new Mock<IJurosAppService>();
            MockJurosAppService();
        }

        [TestMethod]
        public void Dado_os_parametros_validos_deve_calcular_o_juros_composto()
        {
            _retorno = (ObjectResult)_validController.CalcularJurosComposto(_validInput);

            Assert.IsNotNull(_retorno);
            Assert.AreEqual(StatusCodes.Status200OK, _retorno.StatusCode);
            Assert.AreEqual(_validRetorno, _retorno.Value);
        }

        [TestMethod]
        public void Dado_os_parametros_invalidos_deve_interromper_a_execucao_e_retornar_o_motivo()
        {
            _retorno = (ObjectResult)_invalidController.CalcularJurosComposto(_invalidInput);

            Assert.IsNotNull(_retorno);
            Assert.AreEqual(StatusCodes.Status200OK, _retorno.StatusCode);
            Assert.AreEqual(_invalidRetorno, _retorno.Value);
        }

        #region Mock
        private void MockJurosAppService()
        {
            _validAppService.Setup(x => x.CalcularJurosComposto(_validInput)).Returns(_validRetorno);
            _invalidAppService.Setup(x => x.CalcularJurosComposto(_invalidInput)).Returns(_invalidRetorno);
        }
        #endregion
    }
}
