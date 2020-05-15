using DominioNomina;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasUnitarias
{
    [TestClass]
    public class ServicioPagarEmpleadosTest
    {

        [TestMethod]
        public void Salario_Operario_Deberia_Ser_Subsidio_Mas_Minimo() {

            var servicioPagarEmpleados = new ServicioPagarEmpleados();            

            var pagoEmpleado = servicioPagarEmpleados.pagar(new Empleado("Juan", "Botero", "99999", DateTime.Today, Cargo.OPERARIO));

            Assert.AreEqual(pagoEmpleado.ValorSalario, 1083510);

        }


        [TestMethod]
        public void Salario_Supervisor_Deberia_Ser_Dos_Minimos()
        {

            var servicioPagarEmpleados = new ServicioPagarEmpleados();

            var pagoEmpleado = servicioPagarEmpleados.pagar(new Empleado("Juan", "Botero", "99999", DateTime.Today, Cargo.SUPERVISOR));

            Assert.AreEqual(pagoEmpleado.ValorSalario, 1961314);

        }


    }
}
