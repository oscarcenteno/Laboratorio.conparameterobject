using System;

namespace Negocio.ValoracionesPorISIN.ConParameterObject
{
    public class DiasAlVencimiento
    {
        TimeSpan laDiferenciaEntreLasFechas;

        public DiasAlVencimiento(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial)
        {
            laDiferenciaEntreLasFechas = laFechaDeVencimientoDelValorOficial.Subtract(laFechaActual);
        }

        public double ComoNumeros()
        {
            return laDiferenciaEntreLasFechas.TotalDays;
        }

    }
}
