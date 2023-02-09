
using io.quind.practicaBanco.data.DBContexts;
using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using io.quind.practicaBanco.domain.Models.Clientes.Repositories;
using io.quind.practicaBanco.domain.Models.Clientes.Services;
using io.quind.practicaBanco.entity.ClientesEntities;

namespace io.quind.practicaBanco.data.Repositories
{
    public class ClienteRepository:IClienteRepository
    {
        private readonly IAssembler<ClienteEntidad, Cliente> _modelAssembler;
        private readonly IAssembler<Cliente, ClienteEntidad> _entityAssembler;
        private readonly BancoEjercicioContext _contex;

        public ClienteRepository(BancoEjercicioContext contex,
            IAssembler<Cliente, ClienteEntidad> entityAssembler,
            IAssembler<ClienteEntidad, Cliente> modelAssembler)
        {
            _contex = contex;
            _entityAssembler= entityAssembler;
            _modelAssembler= modelAssembler;
        }

        public void Crear(Cliente cliente)
        {
            try
            {
                var clienteDB = _contex.ClienteEntidads.Add(_entityAssembler.AssemblerObject(cliente));
                if (clienteDB == null)
                {
                    _contex.SaveChanges();

                }
            }
            catch (Exception ex)
            {
          
            }
        }

        public Cliente? BuscarPorNumIden(int numero)
        {
            Cliente cliente = null;
            try
            {
                var clienteDb = _contex.ClienteEntidads.FirstOrDefault(c =>c.NumeroIdentificacion.Equals(numero));
                cliente = _modelAssembler.AssemblerObject(clienteDb);
            }
            catch (Exception ex)
            {

            }
            return cliente;
        }

        public bool Eliminar(int id)
        {
            var clienteDb = _contex.ClienteEntidads.Find(id);
            if (clienteDb != null)
            {
                _contex.ClienteEntidads.Remove(clienteDb);
                _contex.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Editar(Cliente cliente)
        {

            var clienteDb = _contex.ClienteEntidads.FirstOrDefault(c => c.NumeroIdentificacion == cliente.NumeroIdentificacion);

            if (clienteDb != null)

            {
                
                clienteDb.NumeroIdentificacion = cliente.NumeroIdentificacion;
                clienteDb.Nombre = cliente.Nombre;
                clienteDb.Apellido = cliente.Apellido;
                clienteDb.TiposIdentificacion = (int)cliente.TiposIdentificacion;
                clienteDb.Email = cliente.Email;
                clienteDb.FechaNacimiento = cliente.FechaNacimiento;
                clienteDb.FechaActualizacionRegistro = cliente.FechaActualizacionRegistro;
                _contex.ClienteEntidads.Update(clienteDb);
                _contex.SaveChanges();
                return true;
            }
            return false;
        }

        public void Save(Cliente cliente)
        {
            try
            {
                _contex.ClienteEntidads.Add(_entityAssembler.AssemblerObject(cliente));
                _contex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error");
            }
        }
    }
}

