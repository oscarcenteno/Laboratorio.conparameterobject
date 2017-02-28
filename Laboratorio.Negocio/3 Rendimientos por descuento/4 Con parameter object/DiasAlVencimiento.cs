using System;

namespace Negocio.RendimientosPorDescuento.ConParameterObject
{
    public class DiasAlVencimiento
    {
        TimeSpan elTiempoAlVencimiento;

        public DiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            elTiempoAlVencimiento = laFechaDeVencimiento - laFechaActual;
        }

        public decimal ComoNumero()
        {
            return elTiempoAlVencimiento.Days;
        }
    }
}