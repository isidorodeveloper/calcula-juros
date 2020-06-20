using Softplan.CalculaJuros.AppServices.Interfaces.Juros;
using Softplan.CalculaJuros.AppServices.Interfaces.TaxaJuros;
using Softplan.CalculaJuros.AppServices.Juros;
using Softplan.CalculaJuros.AppServices.TaxaJuros;
using System;
using System.Collections.Generic;

namespace Softplan.CalculaJuros.AppServices.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var result = new Dictionary<Type, Type>();

            #region Taxa Juros
            result.Add(typeof(ITaxaJurosAppService), typeof(TaxaJurosAppService));
            #endregion

            #region Juros
            result.Add(typeof(IJurosAppService), typeof(JurosAppService));
            #endregion

            return result;
        }

    }
}
