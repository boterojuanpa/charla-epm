using DominioNomina;
using System;
using System.Globalization;

namespace ConsolaNomina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuracion de datos
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del empleado: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la identificación del empleado: ");
            string identificacion = Console.ReadLine();

            Console.Write("Ingrese la fecha de inicio en la compañia (Ej: 31/12/1987): ");
            DateTime fechaIngreso = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Empleado empleado = new Empleado(nombre, apellido, identificacion, fechaIngreso, ObtenerCargo());

            var servicioPagarEmpleado = new ServicioPagarEmpleados();

            //Ejecucion del proceso
            PagoEmpleado pago = servicioPagarEmpleado.pagar(empleado);

            Console.Clear();

            // Presentación de resultados
            Console.WriteLine("El empleado con nombre {0} \n" +
                "lleva {2} años laborando para la empresa \n" +
                "y tiene un salario de: {1} ", 
                empleado.NombreCompleto(), pago.ValorSalario, empleado.AniosLaboradosEnLaEmpresa());

            Console.ReadLine();
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
