using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using io.quind.practicaBanco.domain.Models.Clientes.exceptions;
using io.quind.practicaBanco.domain.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using io.quind.practicaBanco.domain.Models.Clientes.Repositories;

namespace io.quind.practicaBanco.domain.Models.Clientes.RulesImplements
{
    public class RuleCliente:IRuleCliente<Cliente>

    {
        public readonly IClienteRepository clienteRepository;
        public RuleCliente(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;     
        }
        public void Validar(Cliente model) 
        {
            if (model != null) 
            {
                validarMayorEdad(model.FechaNacimiento);
                validarNumeroIdentificacion(model.NumeroIdentificacion);
                //validarExistencia(model.NumeroIdentificacion);
            }
        }

        private void validarMayorEdad(DateTime fechanacimiento)
        {
            if ((DateTime.Now - fechanacimiento).Days / 365.25 < 18)
            {
                throw new ClienteException("cliente menor de edad");
            }
        }
        private void validarNumeroIdentificacion(int numer)
        {
            try
            {
                int b = numer + 0;
            }

            catch
            {
                throw new ("numero de caracteres en apellido o nombre incorrecto");

            }
        }
        private void validarExistencia(int identificationNumber)
        {
            if (clienteRepository.BuscarPorNumIden(identificationNumber) != null)
            {
                throw new ClienteException("cliente no es correcto");
            }
        }


    }

}

