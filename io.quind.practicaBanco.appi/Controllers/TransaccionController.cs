using io.quind.practicaBanco.domain.Service;
using io.quind.practicaBanco.DTO.TransaccionDTOS;
using Microsoft.AspNetCore.Mvc;


namespace io.quind.practicaBanco.ap.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransaccionController: ControllerBase
    {
        private readonly ITransaccionService _transaccion;

    public TransaccionController(ITransaccionService transaccion)
    {
        _transaccion = transaccion;
    }

    [HttpGet("{id:int}")]
    public IActionResult getCliente(int id)
    {
        try
        {
            var oTransaccion = _transaccion.findById(id);
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
    public IActionResult crear(TransaccionRequestDto transaccion)

    {

        if (_transaccion.Crear(transaccion.obtenerTransaccion()))
        {
            return Ok(new { message = "cliente creado" });
        }
        else
            return NotFound();


    }
 
    
    }
}
