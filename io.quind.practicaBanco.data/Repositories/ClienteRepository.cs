

using io.quind.practicaBanco.data.ClienteFactories;
using io.quind.practicaBanco.data.DBContexts;
using io.quind.practicaBanco.domain.Service;
using io.quind.practicaBanco.entity.ClientesEntities;
using io.quind.practicaBanco.Models.Clientes;

namespace io.quind.practicaBanco.data.Repositories
{
    public class ClienteRepository:IClienteService
    {
        private readonly BancoEjercicioContext _contex;

        public ClienteRepository(BancoEjercicioContext contex)
        {
            _contex = contex;
        }

        public bool Crear(Cliente cliente)
        {
            try
            {
                var clienteDB = _contex.ClienteEntidads.Add(ClienteFactory.DominioAEntidad(cliente));
                if (clienteDB != null)
                {
                    _contex.SaveChanges();

                }
                return true;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Cliente findById(int id)
        {
            Cliente cliente = new Cliente();
            try
            {
                var clienteDb = _contex.ClienteEntidads.Find(id);

                cliente = ClienteFactory.EntidadAdominio(clienteDb ?? new ClienteEntidad());
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







    }
}

