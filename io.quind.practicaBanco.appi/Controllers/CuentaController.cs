using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;
using io.quind.practicaBanco.domain.Models.Cuentas.Services;
using io.quind.practicaBanco.DTO.CuentaDTOS;
using Microsoft.AspNetCore.Mvc;


namespace io.quind.practicaBanco.appi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuentaController:ControllerBase
    {
        private readonly ICuentaService _cuenta;
        private readonly IAssembler<CuentaRequest, Cuenta> _assembler;

        public CuentaController(ICuentaService cuenta, IAssembler<CuentaRequest, Cuenta> assembler)
        {
            _cuenta = cuenta;
            _assembler = assembler;
        }

        [HttpGet("{numero:int}")]
        public IActionResult getCuenta(int numero)
        {
            try
            {
                var oCuenta = _cuenta.BuscarPorNumCuen(numero);
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
        public IActionResult crear(CuentaRequest model)
        {
            _cuenta.Crear(_assembler.AssemblerObject(model));
             return Ok(new { message = "cuenta creado" });
        }
        [HttpDelete("{id:int}" )]
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
                _cuenta.Editar(_assembler.AssemblerObject(cuenta));
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


