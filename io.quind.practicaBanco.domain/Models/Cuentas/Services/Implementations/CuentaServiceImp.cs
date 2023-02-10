

using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using io.quind.practicaBanco.domain.Models.Clientes.Repositories;
using io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;
using io.quind.practicaBanco.domain.Models.Cuentas.Repositories;
using io.quind.practicaBanco.domain.Rules;

namespace io.quind.practicaBanco.domain.Models.Cuentas.Services.Implementations;
public class CuentaServiceImp : ICuentaService
{
    private readonly IRuleCuenta<Cuenta> rule;
    private readonly ICuentaRepository cuentaRepository;
    public CuentaServiceImp(IRuleCuenta<Cuenta> rule,ICuentaRepository cuentaRepository)
    {
        this.rule = rule;
        this.cuentaRepository = cuentaRepository;
    }

    public Cuenta BuscarPorNumCuen(int numero)
    {
        return cuentaRepository.BuscarPorNumCuen(numero);
    }
    public void Crear(Cuenta model)
    {
        CrearNumeroCuenta(model);
        model.FechaCreacionCuenta = DateTime.Now;
        model.FechaActualizacionCuenta= DateTime.Now;
        cuentaRepository.Save(model);
    }
    public bool Editar(Cuenta cuenta)
    {
        cuenta.FechaActualizacionCuenta = DateTime.Now;
        cuentaRepository.Editar(cuenta);
        return true;
    }

    public void Eliminar(int id)
    {
        rule.ValidarEli(id);
    }
    private void CrearNumeroCuenta(Cuenta cuenta)
    {
        Random random = new Random();
        if ((int)cuenta.TipoCuenta == 1)
        {
            cuenta.NumeroCuenta = random.Next(53000000, 53999999);
            cuenta.EstadoCuenta = (EstadoCuentaCliente)1;
            cuenta.Saldo = 0;
            //cuenta.ExentoGmf = 1;
        }
        if ((int)cuenta.TipoCuenta == 2)
        {
            cuenta.NumeroCuenta = random.Next(33000000, 33999999);
            cuenta.Saldo = 0;
            //cuenta.ExentoGmf = 1;
        }
    }
}



