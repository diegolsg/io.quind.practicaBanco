using io.quind.practicaBanco.data.DBContexts;
using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;
using io.quind.practicaBanco.domain.Models.Cuentas.exceptions;
using io.quind.practicaBanco.domain.Models.Cuentas.Repositories;
using io.quind.practicaBanco.domain.Models.Cuentas.Services;
using io.quind.practicaBanco.entity.CuentasEntities;


namespace io.quind.practicaBanco.data.Repositories
{
    public class CuentaRepository : ICuentaRepository
    {
        private readonly IAssembler<CuentaEntidad, Cuenta> _modelAssembler;
        private readonly IAssembler<Cuenta, CuentaEntidad> _entityAssembler;
        private readonly BancoEjercicioContext _contex;

        public CuentaRepository(BancoEjercicioContext contex,
            IAssembler<CuentaEntidad, Cuenta> modelAssembler,
            IAssembler<Cuenta, CuentaEntidad> entityAssembler)
        {
            _contex = contex;
            _entityAssembler = entityAssembler;
            _modelAssembler = modelAssembler;
        }

        public void Crear(Cuenta cuenta)
        {
            try
            {
                var cuentaDB = _contex.CuentaEntidads.Add(_entityAssembler.AssemblerObject(cuenta));
                if (cuentaDB != null)
                {
                    _contex.SaveChanges();

                }
            }
            catch (Exception ex)
            {
             
            }
        }

        public Cuenta? BuscarPorNumCuen(int numero)
        {
            Cuenta cuenta = null;
            try
            {
                var cuentaDb = _contex.CuentaEntidads.FirstOrDefault(c => c.NumeroCuenta.Equals(numero));
                cuenta = _modelAssembler.AssemblerObject(cuentaDb);
            }
            catch (Exception ex)
            {

            }
            return cuenta;
        }

        public void Eliminar(int id)
        {
            var cuentaDb = _contex.CuentaEntidads.Find(id);
            if (cuentaDb != null)
            {
                if (cuentaDb.Saldo == 0)
                {
                    _contex.CuentaEntidads.Remove(cuentaDb);
                    _contex.SaveChanges();
                    
                }
                else 
                {
                    throw new CuentaException("tiene saldos pendientes");

                }

            }
            
            
        }

        public bool Editar(Cuenta cuenta)
        {

            var cuentaDb = _contex.CuentaEntidads.FirstOrDefault(c=>c.NumeroCuenta==cuenta.NumeroCuenta);

            if (cuentaDb != null)

            {
                cuentaDb.EstadoCuenta = (int)cuenta.EstadoCuenta;
                cuentaDb.ExentoGmf = cuenta.ExentoGmf;
                cuentaDb.FechaActualizacionCuenta = cuenta.FechaActualizacionCuenta;
                _contex.CuentaEntidads.Update(cuentaDb);
                _contex.SaveChanges();
                return true;

            }

            return false;

        }

        public void Save(Cuenta cuenta)
        {
            try
            {
                _contex.CuentaEntidads.Add(_entityAssembler.AssemblerObject(cuenta));
                _contex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error");
            }
        }
    }
}


