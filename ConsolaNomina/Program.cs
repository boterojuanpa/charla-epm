using DominioNomina;
using System;
using System.Globalization;

namespace ConsolaNomina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del empleado: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la identificación del empleado: ");
            string identificacion = Console.ReadLine();

            Console.Write("Ingrese la fecha de inicio en la compañia (Ej: 31/12/1987): ");
            DateTime fechaIngreso = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);


            var servicioPagarEmpleado = new ServicioPagarEmpleados();

            Empleado empleado = new Empleado(nombre, apellido, identificacion, fechaIngreso, ObtenerCargo());

            PagoEmpleado pago = servicioPagarEmpleado.pagar(empleado);

            Console.Clear();
            Console.WriteLine("El empleado con nombre {0} \n" +
                "lleva {2} años laborando para la empresa \n" +
                "y tiene un salario básico de: {1} " +
                "y una bonificacion de {3} " +
                "Para un salario neto de: {4}", 
                empleado.NombreCompleto(), pago.ValorSalarioBasico, 
                empleado.AniosLaboradosEnLaEmpresa(), 
                pago.ValorBonificacion,
                pago.ValorSalarioTotal);            
                 
        }


        private static Cargo ObtenerCargo()
        {
            Console.Clear();
            Console.WriteLine("Seleccione un cargo");
            Console.WriteLine("1) OPERARIO");
            Console.WriteLine("2) SUPERVISOR");
            switch (Console.ReadLine())
            {
                case "1":
                    return Cargo.OPERARIO;
                case "2":
                    return Cargo.SUPERVISOR;
                default:
                    throw new Exception("No ha seleccionado un valor correcto");
            }
        }
    }
}
