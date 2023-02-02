using io.quind.practicaBanco.domain.Service;
using io.quind.practicaBanco.DTO.ClienteDTOS;
using Microsoft.AspNetCore.Mvc;
using o.quind.practicaBanco.DTO.ClienteDTOS;

namespace io.quind.practicaBanco.ap.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _cliente;

        public ClienteController(IClienteService cliente)
        {
            _cliente = cliente;
        }

        [HttpGet("{id:int}")]
        public IActionResult getCliente(int id)
        {
            try
            {
                var oCliente = _cliente.findById(id);
                if (oCliente == null)
                {
                    return NotFound();
                }
                var oClienteDto = ClienteResponseDto.Of(oCliente);
                return Ok(oClienteDto);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult crear(ClienteRequestDto cliente)

        {

            if (_cliente.Crear(cliente.obtenerCliente()))
            {
                return Ok(new { message = "cliente creado" });
            }
            else
                return NotFound();


        }
        [HttpDelete("{id:int}")]
        public IActionResult Eliminar(int id)
        {
            _cliente.Eliminar(id);
            return Ok(new { message = "cliente eliminado" });
        }
        [HttpPut]
        public IActionResult Editar(ClienteRequestDto cliente)
        {
            try
            {
                _cliente.Editar(cliente.obtenerCliente());
                return Ok(new { message = "cliente editado" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
    //[HttpGet]
    //public IActionResult GetCliente(ClienteEntidad cliente)
    //{
    //    var usuario = _cliente.GetCliente();
    //    return Ok(usuario);
    //}

    //    }

