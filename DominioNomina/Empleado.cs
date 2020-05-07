using System;

namespace DominioNomina
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private string identificacion;
        private DateTime fechaIngresoEmpresa;
        private Cargo cargo;

        public Empleado(string nombre, string apellido, string identificacion, DateTime fechaIngresoEmpresa, Cargo cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.identificacion = identificacion;
            this.fechaIngresoEmpresa = fechaIngresoEmpresa;
            this.cargo = cargo;
        }

        public string Identificacion {
            get { return identificacion; }
        }

        public Cargo Cargo {
            get { return cargo; }
        }

       public string NombreCompleto() {
            return nombre + " " + apellido; 
       }

        public int AniosLaboradosEnLaEmpresa() {
            return Convert.ToInt32((DateTime.Today - fechaIngresoEmpresa).TotalDays / 365.2425);
        }
       
        
        
    }
}
