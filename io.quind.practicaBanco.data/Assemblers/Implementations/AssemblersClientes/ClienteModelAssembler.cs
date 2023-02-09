using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using io.quind.practicaBanco.entity.ClientesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.data.Assemblers.Implementations.AssemblersClientes
{
    public class ClienteModelAssembler : IAssembler<ClienteEntidad, Cliente>
    {
        public Cliente AssemblerObject(ClienteEntidad Tin)
        {
            return new Cliente
            {
                Id = Tin.Id,
                TiposIdentificacion = (TipoIdentificacionCliente)Tin.TiposIdentificacion,
                NumeroIdentificacion = Tin.NumeroIdentificacion,
                Nombre = Tin.Nombre,
                Apellido = Tin.Apellido,
                Email = Tin.Email,
                FechaNacimiento = Tin.FechaNacimiento,
                FechaCreacionRegistro = Tin.FechaCreacionRegistro,
                FechaActualizacionRegistro = Tin.FechaActualizacionRegistro
            };
        }
    }
}
