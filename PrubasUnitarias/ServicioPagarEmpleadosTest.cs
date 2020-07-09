using DominioNomina;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrubasUnitarias
{
    [TestClass]
    public class ServicioPagarEmpleadosTest
    {

        [TestMethod]
        public void Salario_Operario_Deberia_Ser_Subsido_TRansporte_Mas_Minimo() {
            
            //Arrange
            var empleado = new Empleado("Juan", "Botero", "1111111",
                new System.DateTime(2000, 10, 1), Cargo.OPERARIO);
            var servicioPagarEmpleados = new ServicioPagarEmpleados();
            //Act
            var pagoEmpleado = servicioPagarEmpleados.pagar(empleado);
            //Assert
            Assert.AreEqual(1083510, pagoEmpleado.ValorSalario);
        }

        [TestMethod]
        public void Salario_Supervisor_Deberia_Ser_Dos_Minimos()
        {
            //Arrange
            var empleado = new Empleado("Juan", "Botero", "1111111",
                new System.DateTime(2000, 10, 1), Cargo.SUPERVISOR);
            var servicioPagarEmpleados = new ServicioPagarEmpleados();
            //Act
            var pagoEmpleado = servicioPagarEmpleados.pagar(empleado);
            //Assert
            Assert.AreEqual(1961314, pagoEmpleado.ValorSalario);
        }

        [TestMethod]
        public void Salario_Gerente_Deberia_Ser_Cinco_Minimos()
        {
            //Arrange
            var empleado = new Empleado("Juan", "Botero", "1111111",
                new System.DateTime(2000, 10, 1), Cargo.GERENTE);
            var servicioPagarEmpleados = new ServicioPagarEmpleados();
            //Act
            var pagoEmpleado = servicioPagarEmpleados.pagar(empleado);
            //Assert
            Assert.AreEqual(4903285, pagoEmpleado.ValorSalario);
        }

        [TestMethod]
        public void Calculo_Pago_Con_Salario_Minimo_Menor_900000_Deberia_Lanzar_Excepcion()
        {
            //Arrange
            var empleado = new Empleado("Juan", "Botero", "1111111",
                new System.DateTime(2000, 10, 1), Cargo.GERENTE);
            var servicioPagarEmpleados = new ServicioPagarEmpleados(899999);

            try {
                //Act
                var pagoEmpleado = servicioPagarEmpleados.pagar(empleado);
                Assert.Fail();
            }
            catch (Exception e) {
                // Assert
                Assert.AreEqual("El valor del salario minimo no debería ser menor a 900.000", e.Message);
            }
        }

        [TestMethod]
        public void Calculo_Pago_Con_Salario_Minimo_Mayor_900000_Deberia_Calcular_Normalmente()
        {
            //Arrange
            var empleado = new Empleado("Juan", "Botero", "1111111",
                new System.DateTime(2000, 10, 1), Cargo.GERENTE);
            var servicioPagarEmpleados = new ServicioPagarEmpleados(900001);
            //Act
            var pagoEmpleado = servicioPagarEmpleados.pagar(empleado);
            //Assert
            Assert.AreEqual(4500005, pagoEmpleado.ValorSalario);
        }

    }
}
