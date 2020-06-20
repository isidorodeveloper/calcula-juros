using Softplan.CalculaJuros.Services.Interfaces.Juros;
using Softplan.CalculaJuros.Services.Interfaces.TaxaJuros;
using Softplan.CalculaJuros.Services.Juros;
using Softplan.CalculaJuros.Services.TaxaJuros;
using System;
using System.Collections.Generic;

namespace Softplan.CalculaJuros.Services.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var result = new Dictionary<Type, Type>();

            #region Taxa Juros
            result.Add(typeof(ITaxaJurosService), typeof(TaxaJurosService));
            #endregion

            #region Juros
            result.Add(typeof(IJurosService), typeof(JurosService));
            #endregion

            return result;
        }
    }
}
