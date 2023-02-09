using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using io.quind.practicaBanco.DTO.ClienteDTOS;

namespace io.quind.practicaBanco.ap.Assemblers.Implementations
{
    public class ClienteImpDto : IAssembler<ClienteRequestDto, Cliente>
    {
        public Cliente AssemblerObject(ClienteRequestDto Tin)
        {
            return new Cliente
            {
                TiposIdentificacion=(TipoIdentificacionCliente)Tin.TipoIdentificacion,
                NumeroIdentificacion=Tin.NumeroIdentificacion,
                Nombre=Tin.Nombre,
                Apellido=Tin.Apellido,
                Email=Tin.Email,
                FechaNacimiento=Tin.FechaNacimiento
            };
        }
    }
}
