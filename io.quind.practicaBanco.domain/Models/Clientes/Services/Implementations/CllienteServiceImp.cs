using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using io.quind.practicaBanco.domain.Models.Clientes.Repositories;
using io.quind.practicaBanco.domain.Rules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Models.Clientes.Services.Implementations;
public class ClienteServiceImp : IClienteService
{ 

    private readonly IRuleCliente<Cliente> rule;
    private readonly IClienteRepository clienteRepository;
    public ClienteServiceImp(IRuleCliente<Cliente> rule, IClienteRepository clienteRepository)
    {
        this.rule = rule;
        this.clienteRepository = clienteRepository;
    }
  
    public void Crear(Cliente cliente)
    {
        rule.Validar(cliente);
        cliente.FechaCreacionRegistro = DateTime.Now;
        cliente.FechaActualizacionRegistro= DateTime.Now;
        clienteRepository.Save(cliente);
       
    }

    public bool Editar(Cliente cliente)
    {
        rule.Validar(cliente);
        cliente.FechaActualizacionRegistro=DateTime.Now;
        clienteRepository.Editar(cliente);
        return true;
    }
        
    public bool Eliminar(int id)
    {
        clienteRepository.Eliminar(id);
        return true;
    }

    public Cliente BuscarPorNumIden(int numero)
    {
       return clienteRepository.BuscarPorNumIden(numero);   
    }
}

   

