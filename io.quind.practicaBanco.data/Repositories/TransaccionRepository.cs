using io.quind.practicaBanco.data.DBContexts;
using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Transacciones.Repositories;
using io.quind.practicaBanco.domain.Models.Transacciones.Services;
using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;
using io.quind.practicaBanco.entity.TransaccionesEntities;

namespace io.quind.practicaBanco.data.Repositories
{
    public class TransaccionRepository:ITransaccionRepository

    {
        private readonly IAssembler<TransaccionEntidad,Transaccion> _modelAssembler;
        private readonly IAssembler<Transaccion,TransaccionEntidad> _entityAssembler;
        private readonly BancoEjercicioContext _context;
        public TransaccionRepository(BancoEjercicioContext context,
            IAssembler<TransaccionEntidad, Transaccion> modelAssembler, 
            IAssembler<Transaccion, TransaccionEntidad> entityAssembler)
        {
            _context = context;
            _modelAssembler = modelAssembler;
            _entityAssembler = entityAssembler;
        }
        public void Crear(Transaccion transaccion)
        {
            try
            {
                var transaccionDB = _context.TransaccionEntidads.Add(_entityAssembler.AssemblerObject(transaccion));
                if (transaccionDB != null)
                {
                    _context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
              
            }
        }

        public Transaccion BuscarPorNumCuen(int id)
        {
            Transaccion transaccion = new Transaccion();
            try
            {
                var transaccionDb = _context.TransaccionEntidads.Find(id);

                transaccion =_modelAssembler.AssemblerObject(transaccionDb ?? new TransaccionEntidad());
            }
            catch (Exception ex)
            {

            }
            return transaccion;
        }

    
    }
}
