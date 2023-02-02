
using io.quind.practicaBanco.domain.Service;
using io.quind.practicaBanco.DTO.ClienteDTOS;
using io.quind.practicaBanco.DTO.CuentaDTOS;
using Microsoft.AspNetCore.Mvc;
using o.quind.practicaBanco.DTO.ClienteDTOS;

namespace io.quind.practicaBanco.appi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuentaController:ControllerBase
    {
        private readonly ICuentaService _cuenta;

        public CuentaController(ICuentaService cliente)
        {
            _cuenta = cliente;
        }

        [HttpGet("{id:int}")]
        public IActionResult getCliente(int id)
        {
            try
            {
                var oCuenta = _cuenta.findById(id);
                if (oCuenta == null)
                {
                    return NotFound();
                }
                var oCuentaDto = CuentaResponseDTO.of(oCuenta);
                return Ok(oCuentaDto);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult crear(CuentaRequest cuenta)

        {

            if (_cuenta.Crear(cuenta.obtenerCuenta()))
            {
                return Ok(new { message = "cliente creado" });
            }
            else
                return NotFound();


        }
        [HttpDelete("{id:int}")]
        public IActionResult Eliminar(int id)
        {
            _cuenta.Eliminar(id);
            return Ok(new { message = "cuenta eliminada" });
        }
        [HttpPut]
        public IActionResult Editar(CuentaRequest cuenta)
        {
            try
            {
                _cuenta.Editar(cuenta.obtenerCuenta());
                return Ok(new { message = "cuenta editada" });
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


