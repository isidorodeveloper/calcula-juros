using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Softplan.CalculaJuros.Api.Controllers.TaxaJuros;
using Softplan.CalculaJuros.AppServices.Interfaces.TaxaJuros;

namespace Softplan.CalculaJuros.Tests.Api.TaxaJuros
{
    [TestClass]
    public class TaxaJurosControllerTests
    {
        private Mock<ITaxaJurosAppService> _appService;
        private readonly TaxaJurosController _controller;
        private ObjectResult _retorno;

        public TaxaJurosControllerTests()
        {
            ConfigurarAppSerice();
            _controller = new TaxaJurosController(_appService.Object);
        }

        private void ConfigurarAppSerice()
        {
            _appService = new Mock<ITaxaJurosAppService>();
            MockTaxaJurosAppService();
        }

        [TestMethod]
        public void Deve_retornar_taxa_juros_de_um_por_cento()
        {
            _retorno = (ObjectResult)_controller.ObterTaxaJuros();

            Assert.IsNotNull(_retorno);
            Assert.AreEqual(StatusCodes.Status200OK, _retorno.StatusCode);
            Assert.AreEqual(0.01m, _retorno.Value);
        }

        #region Mock
        private void MockTaxaJurosAppService()
        {
            _appService.Setup(x => x.ObterTaxaJuros(1)).Returns(0.01m);
        }
        #endregion
    }
}
