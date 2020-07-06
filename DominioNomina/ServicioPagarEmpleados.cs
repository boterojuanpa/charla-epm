
namespace DominioNomina
{
    public class ServicioPagarEmpleados
    {
        private const double SALARIO_MINIMO = 980657;
        private const double SUBSIDIO_TRANSPORTE = 102853;

        public PagoEmpleado pagar(Empleado empleado)
        {
            PagoEmpleado pagoEmpleado = null;
            if (empleado.Cargo.Equals(Cargo.OPERARIO))
            {
                pagoEmpleado = GenerarPagoOperario(empleado);
            }
            else if (empleado.Cargo.Equals(Cargo.SUPERVISOR))
            {
                pagoEmpleado = GenerarPagoSupervisor(empleado);
            }
            else if (empleado.Cargo.Equals(Cargo.GERENTE))
            {
                pagoEmpleado = new PagoEmpleado(empleado, SALARIO_MINIMO * 5, 0);
            }
            return pagoEmpleado;
        }

        private static PagoEmpleado GenerarPagoSupervisor(Empleado empleado)
        {
            PagoEmpleado pagoEmpleado;
            double bonificacion = ObtenerBonificacionSupervisor(empleado);
            pagoEmpleado = new PagoEmpleado(empleado, SALARIO_MINIMO * 2, bonificacion);
            return pagoEmpleado;
        }

        private static double ObtenerBonificacionSupervisor(Empleado empleado)
        {
            double bonificacion = 0;
            if (empleado.AniosLaboradosEnLaEmpresa() >= 4)
            {
                bonificacion = empleado.AniosLaboradosEnLaEmpresa() * 100000;
            }

            return bonificacion;
        }

        private PagoEmpleado GenerarPagoOperario(Empleado empleado)
        {
            PagoEmpleado pagoEmpleado;
            double salarioBasicoOperario = SALARIO_MINIMO + SUBSIDIO_TRANSPORTE;
            double bonificacion = ObtenerBonificacionOperario(empleado, salarioBasicoOperario);
            pagoEmpleado = new PagoEmpleado(empleado, salarioBasicoOperario, bonificacion);
            return pagoEmpleado;
        }

        private double ObtenerBonificacionOperario(Empleado empleado, double salarioBasicoOperario)
        {
            double bonificacion = 0;
            if (empleado.AniosLaboradosEnLaEmpresa() >= 3)
            {
                bonificacion = salarioBasicoOperario * 0.1;
            }

            return bonificacion;
        }
    }
}
