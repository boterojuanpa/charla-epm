namespace DominioNomina
{
    public class PagoEmpleado
    {
        private Empleado empleado;
        private double valorSalario;

        public PagoEmpleado(Empleado empleado, double valorSalario)
        {
            this.empleado = empleado;
            this.valorSalario = valorSalario;
        }

        public double ValorSalario {
            get { return valorSalario; }
        }

        public Empleado Empleado {
            get { return empleado; }
        }
    }
}