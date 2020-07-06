namespace DominioNomina
{
    public class PagoEmpleado
    {
        private Empleado empleado;
        private double valorSalarioBasico;
        private double bonificacion;

        public PagoEmpleado(Empleado empleado, double valorSalarioBasico, double bonificacion)
        {
            this.empleado = empleado;
            this.valorSalarioBasico = valorSalarioBasico;
            this.bonificacion = bonificacion;
        }

        public double ValorSalarioBasico {
            get { return valorSalarioBasico; }
        }

        public double ValorBonificacion
        {
            get { return bonificacion; }
        }

        public double ValorSalarioTotal
        {
            get { return bonificacion + valorSalarioBasico; }
        }

        public Empleado Empleado {
            get { return empleado; }
        }
    }
}