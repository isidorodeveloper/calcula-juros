﻿using System;

namespace Softplan.CalculaJuros.Utils.Helpers
{
    public static class TruncateExtension
    {
        public static decimal TruncateDecimal(this decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal tmp = Math.Truncate(step * value);
            return tmp / step;
        }
    }
}
