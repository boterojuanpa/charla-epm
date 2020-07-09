
using System;

namespace DominioNomina
{
    public class ServicioPagarEmpleados
    {
        private double SALARIO_MINIMO = 980657;
        private double SUBSIDIO_TRANSPORTE = 102853;

        public ServicioPagarEmpleados() { 
        }

        public ServicioPagarEmpleados(double salarioMinimo) {
            this.SALARIO_MINIMO = salarioMinimo;
        }

        public PagoEmpleado pagar(Empleado empleado)
        {
            if (this.SALARIO_MINIMO < 900000) {
               throw new Exception("El valor del salario minimo no debería ser menor a 900.000");
            }

            PagoEmpleado pagoEmpleado = null;
            if (empleado.Cargo.Equals(Cargo.OPERARIO)) {
                pagoEmpleado = new PagoEmpleado(empleado, 1040000  + SUBSIDIO_TRANSPORTE);
            }
            else if (empleado.Cargo.Equals(Cargo.SUPERVISOR)) {
                pagoEmpleado = new PagoEmpleado(empleado, SALARIO_MINIMO * 2);
            }
            else if (empleado.Cargo.Equals(Cargo.GERENTE))
            {
                pagoEmpleado = new PagoEmpleado(empleado, SALARIO_MINIMO * 5);
            }
            return pagoEmpleado;
        }
    }
}
