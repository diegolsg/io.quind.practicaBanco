using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;
using io.quind.practicaBanco.domain.Models.Transacciones.Services;
using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;
using io.quind.practicaBanco.DTO.CuentaDTOS;
using io.quind.practicaBanco.DTO.TransaccionDTOS;
using Microsoft.AspNetCore.Mvc;


namespace io.quind.practicaBanco.ap.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransaccionController: ControllerBase
    {
        private readonly ITransaccionService _transaccion;
        private readonly IAssembler<TransaccionRequestDto, Transaccion> _assembler;

        public TransaccionController(ITransaccionService transaccion)
    {
        _transaccion = transaccion;
    }

    [HttpGet("{id:int}")]
    public IActionResult getCliente(int id)
    {
        try
        {
            var oTransaccion = _transaccion.BuscarPorNumCuen(id);
            if (oTransaccion == null)
            {
                return NotFound();
            }
            var oTransaccionDto = TransaccionResponseDto.Of(oTransaccion);
            return Ok(oTransaccionDto);
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult crear(TransaccionRequestDto model)
    {
            _transaccion.Crear(_assembler.AssemblerObject(model));
            return Ok(new { message = "transferencia realizada" });  
    }
 
    
    }
}
