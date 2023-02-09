using io.quind.practicaBanco.domain.Models.Clientes;
using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using io.quind.practicaBanco.domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.unityTest.ClientesTests
{
    [TestClass]
    public class ClienteUnitTest
    {
        [TestMethod]
        public void testClienteValidarNumero()
        {
            string nombre = "d";
            Cliente cliente = new Cliente
            {
                Nombre = "d",
                Email = "email",
                Apellido = "",
                NumeroIdentificacion = 1

            };
            Assert.AreEqual(cliente.Nombre, nombre);
        }
    }
}
