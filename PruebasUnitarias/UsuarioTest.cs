using DominioNomina;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasUnitarias
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void Nombre_Completo_Retorna_Nombre_Apellido()
        {
            var empleado = new Empleado("Juan", "Botero", "999999", new DateTime(2000,10,1), Cargo.GERENTE);

            var nombreCompleto = empleado.NombreCompleto();

            Assert.AreEqual("Juan Botero" , nombreCompleto)
;        }

        [TestMethod]
        public void Anios_Laborados_Retorna_Numero_Anios_Desde_Ingreso_Compania()
        {
            var empleado = new Empleado("Juan", "Botero", "999999", new DateTime(2000, 10, 1), Cargo.GERENTE);

            var aniosLaborados = empleado.AniosLaboradosEnLaEmpresa();

            Assert.AreEqual(20, aniosLaborados)
;
        }
    }
}
