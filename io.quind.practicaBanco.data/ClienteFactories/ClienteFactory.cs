using io.quind.practicaBanco.domain.Models;
using io.quind.practicaBanco.entity.ClientesEntities;
using io.quind.practicaBanco.Models.Clientes;

namespace io.quind.practicaBanco.data.ClienteFactories
{
    public class ClienteFactory
    {

        public static ClienteEntidad DominioAEntidad(Cliente cliente)
        {
            return new ClienteEntidad
            {
                TiposIdentificacion = (int)cliente.TiposIdentificacion,
                NumeroIdentificacion = cliente.NumeroIdentificacion,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Email = cliente.Email,
                FechaNacimiento = cliente.FechaNacimiento,
                FechaCreacionRegistro = cliente.FechaCreacionRegistro,
                FechaActualizacionRegistro = cliente.FechaActualizacionRegistro
            };
        }

        public static Cliente EntidadAdominio(ClienteEntidad cliente)
        {
            return new Cliente
            {
                TiposIdentificacion = (TipoIdentificacionCliente)cliente.TiposIdentificacion,
                NumeroIdentificacion = cliente.NumeroIdentificacion,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Email = cliente.Email,
                FechaNacimiento = cliente.FechaNacimiento,
                FechaCreacionRegistro = cliente.FechaCreacionRegistro,
                FechaActualizacionRegistro = cliente.FechaActualizacionRegistro
            };
        }
    }
}
