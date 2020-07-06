using DominioNomina;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasUnitarias
{
    [TestClass]
    public class ServicioPagarEmpleadosTest
    {

        [TestMethod]
        public void Salario_Basico_Operario_Deberia_Ser_Subsidio_Mas_Minimo() {

            var servicioPagarEmpleados = new ServicioPagarEmpleados();            

            var pagoEmpleado = servicioPagarEmpleados.pagar(new Empleado("Juan", "Botero", "99999", DateTime.Today, Cargo.OPERARIO));

            Assert.AreEqual(pagoEmpleado.ValorSalarioBasico, 1083510);

        }


        [TestMethod]
        public void Salario_Basico_Supervisor_Deberia_Ser_Dos_Minimos()
        {

            var servicioPagarEmpleados = new ServicioPagarEmpleados();

            var pagoEmpleado = servicioPagarEmpleados.pagar(new Empleado("Juan", "Botero", "99999", DateTime.Today, Cargo.SUPERVISOR));

            Assert.AreEqual(pagoEmpleado.ValorSalarioBasico, 1961314);

        }

        [TestMethod]
        public void Salario_Basico_Gerente_Deberia_Ser_Cinco_Minimos()
        {

            var servicioPagarEmpleados = new ServicioPagarEmpleados();

            var pagoEmpleado = servicioPagarEmpleados.pagar(new Empleado("Juan", "Botero", "99999", DateTime.Today, Cargo.GERENTE));

            Assert.AreEqual(pagoEmpleado.ValorSalarioBasico, 4903285);
        }


        [TestMethod]
        public void Bonificacion_Operario_Con_Mas_3_Anios_Antiguedad_Deberia_Ser_Diez_Porciento_Salario_Basico()
        {

            var servicioPagarEmpleados = new ServicioPagarEmpleados();

            
            var pagoEmpleado = servicioPagarEmpleados.pagar(
                new Empleado("Juan", "Botero", "99999", new DateTime(2015, 10, 1), Cargo.OPERARIO));

            Assert.AreEqual(108351, pagoEmpleado.ValorBonificacion);
            Assert.AreEqual(1191861, pagoEmpleado.ValorSalarioTotal);
        }

        [TestMethod]
        public void Bonificacion_Operario_Con_Menos_3_Anios_Antiguedad_Deberia_Ser_Cero()
        {

            var servicioPagarEmpleados = new ServicioPagarEmpleados();


            var pagoEmpleado = servicioPagarEmpleados.pagar(
                new Empleado("Juan", "Botero", "99999", new DateTime(2018, 10, 1), Cargo.OPERARIO));

            Assert.AreEqual(0, pagoEmpleado.ValorBonificacion);
            Assert.AreEqual(1083510, pagoEmpleado.ValorSalarioTotal);
        }

        [TestMethod]
        public void Bonificacion_Supervisor_Con_Mas_4_Anios_Antiguedad_Deberia_Anios_Antiguedad_Multiplicado_Por_100000()
        {

            var servicioPagarEmpleados = new ServicioPagarEmpleados();


            var pagoEmpleado = servicioPagarEmpleados.pagar(
                new Empleado("Juan", "Botero", "99999", new DateTime(2015, 10, 1), Cargo.SUPERVISOR));

            Assert.AreEqual(500000, pagoEmpleado.ValorBonificacion);
            Assert.AreEqual(2461314, pagoEmpleado.ValorSalarioTotal);
        }

        [TestMethod]
        public void Bonificacion_Supervisor_Con_Menos_4_Anios_Antiguedad_Deberia_Cero()
        {

            var servicioPagarEmpleados = new ServicioPagarEmpleados();


            var pagoEmpleado = servicioPagarEmpleados.pagar(
                new Empleado("Juan", "Botero", "99999", new DateTime(2018, 10, 1), Cargo.SUPERVISOR));

            Assert.AreEqual(0, pagoEmpleado.ValorBonificacion);
            Assert.AreEqual(1961314, pagoEmpleado.ValorSalarioTotal);
        }



    }
}
