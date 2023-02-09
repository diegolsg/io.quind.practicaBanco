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
    public class ClienteEntityAssembler : IAssembler<Cliente, ClienteEntidad>
    {
        public ClienteEntidad AssemblerObject(Cliente Tin)
        {
            return new ClienteEntidad
            {
                Id = Tin.Id,
                TiposIdentificacion = (int)Tin.TiposIdentificacion,
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
