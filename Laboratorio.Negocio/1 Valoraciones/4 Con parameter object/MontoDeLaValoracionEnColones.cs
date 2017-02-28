using System;

namespace Negocio.Valoraciones.ConParameterObject
{
    public class MontoDeLaValoracionEnColones
    {
        decimal elMontoSinRedondear;

        public MontoDeLaValoracionEnColones(decimal elMontoNominal, decimal elTipoDeCambio, decimal elPrecioLimpio, decimal elPorcentajeDeCobertura, Monedas elTipoDeMoneda)
        {
            elMontoSinRedondear = ObtengaElMontoSinRedondear(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elPorcentajeDeCobertura, elTipoDeMoneda);
        }

        private static decimal ObtengaElMontoSinRedondear(decimal elMontoNominal, decimal elTipoDeCambio, decimal elPrecioLimpio, decimal elPorcentajeDeCobertura, Monedas elTipoDeMoneda)
        {
            return new MontoSinRedondear(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elPorcentajeDeCobertura, elTipoDeMoneda).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return Math.Round(elMontoSinRedondear, 4);
        }
    }
}