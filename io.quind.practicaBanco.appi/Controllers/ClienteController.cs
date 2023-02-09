
using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using io.quind.practicaBanco.domain.Models.Clientes.Services;
using io.quind.practicaBanco.DTO.ClienteDTOS;
using io.quind.practicaBanco.entity.ClientesEntities;
using Microsoft.AspNetCore.Mvc;
using o.quind.practicaBanco.DTO.ClienteDTOS;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Reflection;

namespace io.quind.practicaBanco.ap.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _cliente;
        private readonly IAssembler<ClienteRequestDto, Cliente> _assembler;

        public ClienteController(IClienteService cliente, 
            IAssembler<ClienteRequestDto, Cliente> assembler)
        {
            _cliente = cliente;
            _assembler = assembler;
        }

        [HttpGet("{numero:int}")]
        public IActionResult getCliente(int numero)
        {
            try
            {
                var oCliente = _cliente.BuscarPorNumIden(numero);
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
        public IActionResult Crear(ClienteRequestDto model)
        {
            try
            {
                _cliente.Crear(_assembler.AssemblerObject(model));
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
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
                _cliente.Editar(_assembler.AssemblerObject(cliente));
                
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

