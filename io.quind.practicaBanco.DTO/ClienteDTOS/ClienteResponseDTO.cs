
using io.quind.practicaBanco.Models.Clientes;
using System.ComponentModel.DataAnnotations;

namespace o.quind.practicaBanco.DTO.ClienteDTOS
{
    public class ClienteResponseDTO
    {
        public string? TipoIdentificacion { get; set; }

        public int? NumeroIdentificacion { get; set; }
        [Required(ErrorMessage = "El campo Número de Identificación es obligatorio")]
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Email { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public DateTime? FechaCreacionRegistro { get; set; }

        public DateTime? FechaActualizacionRegistro { get; set; }


        public static ClienteResponseDTO Of(Cliente cliente)
        {
            return new ClienteResponseDTO
            {

                TipoIdentificacion = cliente.TiposIdentificacion.ToString(),
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
