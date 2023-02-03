

using io.quind.practicaBanco.data.ClienteFactories;
using io.quind.practicaBanco.data.CuentaFactories;
using io.quind.practicaBanco.data.DBContexts;
using io.quind.practicaBanco.domain.Models;
using io.quind.practicaBanco.domain.Models.Clientes;
using io.quind.practicaBanco.domain.Service;
using io.quind.practicaBanco.entity.CuentasEntities;
using io.quind.practicaBanco.Models.Clientes;

namespace io.quind.practicaBanco.data.Repositories
{
    public class CuentaRepository : ICuentaService
    {

        private readonly BancoEjercicioContext _contex;

        public CuentaRepository(BancoEjercicioContext contex)
        {
            _contex = contex;
        }

        public bool Crear(Cuenta cuenta)
        {
            try
            {
                var cuentaDB = _contex.CuentaEntidads.Add(CuentaFactory.DominioAEntidad(cuenta));
                if (cuentaDB != null)
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

        public Cuenta findById(int id)
        {
            Cuenta cuenta = new Cuenta();
            try
            {
                var cuentaDb = _contex.CuentaEntidads.Find(id);

                cuenta = CuentaFactory.EntidadAdominio(cuentaDb ?? new CuentaEntidad());
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
                    throw new ClienteException("numero de caracteres en apellido o nombre incorrecto");

                }

            }
            
            
        }

        public bool Editar(Cuenta cuenta)
        {

            var cuentaDb = _contex.CuentaEntidads.FirstOrDefault(c=>c.ClienteId==cuenta.ClienteId);

            if (cuentaDb != null)

            {
                cuentaDb.TipoCuenta=(int)cuenta.TipoCuenta;
                
                cuentaDb.EstadoCuenta = (int)cuenta.EstadoCuenta;
                cuentaDb.Saldo = cuenta.Saldo;
                cuentaDb.ExentoGmf = cuenta.ExentoGmf;
                cuentaDb.FechaActualizacionCuenta = cuenta.FechaActualizacionCuenta;
                _contex.CuentaEntidads.Update(cuentaDb);
                _contex.SaveChanges();
                return true;

            }

            return false;

        }

    }
}


