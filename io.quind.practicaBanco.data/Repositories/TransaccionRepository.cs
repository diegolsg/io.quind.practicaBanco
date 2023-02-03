
using io.quind.practicaBanco.data.ClienteFactories;
using io.quind.practicaBanco.data.DBContexts;
using io.quind.practicaBanco.data.TransaccionFactories;
using io.quind.practicaBanco.domain.Service;

using io.quind.practicaBanco.entity.TransaccionesEntities;
using io.quind.practicaBanco.Models.Clientes;
using io.quind.practicaBanco.Models.Transacciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.data.Repositories
{
    public class TransaccionRepository:ITransaccionService
    {
        private readonly BancoEjercicioContext _context;
        public TransaccionRepository(BancoEjercicioContext context)
        {
            _context = context;
        }
        public bool Crear(Transaccion transaccion)
        {
            try
            {
                var transaccionDB = _context.TransaccionEntidads.Add(TransaccionFactory.DominioEntidad(transaccion));
                if (transaccionDB != null)
                {
                    _context.SaveChanges();

                }
                return true;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Transaccion findById(int id)
        {
            Transaccion transaccion = new Transaccion();
            try
            {
                var transaccionDb = _context.TransaccionEntidads.Find(id);

                transaccion = TransaccionFactory.EntidadDominio(transaccionDb ?? new TransaccionEntidad());
            }
            catch (Exception ex)
            {

            }
            return transaccion;
        }
    }
}
