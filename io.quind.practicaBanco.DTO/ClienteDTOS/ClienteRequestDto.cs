
using System.ComponentModel.DataAnnotations;

namespace io.quind.practicaBanco.DTO.ClienteDTOS
{
    public class ClienteRequestDto
    {
        public int TipoIdentificacion { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(ErrorMessage = "El campo Número de Identificación es obligatorio")]
        public int NumeroIdentificacion { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el numero de caractres no es apropiado")]
        public string Nombre { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el numero de caractres no es apropiado")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio")]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

    }
}

