
namespace DominioNomina
{
    public class ServicioPagarEmpleados
    {
        private const double SALARIO_MINIMO = 980657;
        private const double SUBSIDIO_TRANSPORTE = 102853;

        public PagoEmpleado pagar(Empleado empleado)
        {
            PagoEmpleado pagoEmpleado = null;
            if (empleado.Cargo.Equals(Cargo.OPERARIO)) {
                pagoEmpleado = new PagoEmpleado(empleado, SALARIO_MINIMO + SUBSIDIO_TRANSPORTE);
            }
            else if (empleado.Cargo.Equals(Cargo.SUPERVISOR)) {
                pagoEmpleado = new PagoEmpleado(empleado, SALARIO_MINIMO * 2);
            }
            return pagoEmpleado;
        }
    }
}
