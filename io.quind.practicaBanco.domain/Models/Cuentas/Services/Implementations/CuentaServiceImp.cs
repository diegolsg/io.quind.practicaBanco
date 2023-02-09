

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

    public void Crear(Cuenta cuenta)
    {
        cuenta.FechaCreacionCuenta = DateTime.Now;
        cuenta.FechaActualizacionCuenta= DateTime.Now;
        cuentaRepository.Save(cuenta);
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
}



