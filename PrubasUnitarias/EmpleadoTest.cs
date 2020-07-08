using DominioNomina;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrubasUnitarias
{
    [TestClass]
    public class EmpleadoTest
    {
        [TestMethod]
        public void Nombre_Completo_Retorna_Nombre_Mas_Apellido()
        {
            //Configuracion de datos 
            var empleado = new Empleado("Juan", "Botero", "1111111",
                new System.DateTime(2000,10,1), Cargo.GERENTE);

            // Ejecución de proceso
            var nombreCompleto = empleado.NombreCompleto();

            // VErificación de resultados
            Assert.AreEqual("Juan Botero", nombreCompleto);

        }
    }
}
