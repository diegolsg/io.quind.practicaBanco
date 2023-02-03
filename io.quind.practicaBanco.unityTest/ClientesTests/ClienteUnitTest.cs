using io.quind.practicaBanco.domain.Models.Clientes;
using io.quind.practicaBanco.Models.Clientes;
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
            
            var exception = Assert.ThrowsException<ClienteException>(() => new Cliente(1, 112, "juna", "gomez", "fdf@fg.com", new DateTime(2000, 1, 23)));
            Assert.AreEqual("numero de caracteres en apellido o nombre incorrecto", exception.Message);
        }
    }
}
