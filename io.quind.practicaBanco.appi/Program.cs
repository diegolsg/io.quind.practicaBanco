using io.quind.practicaBanco.data.DBContexts;
using io.quind.practicaBanco.data.Assemblers.Implementations.AssemblersTransacciones;
using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using io.quind.practicaBanco.DTO.ClienteDTOS;
using io.quind.practicaBanco.entity.ClientesEntities;
using io.quind.practicaBanco.data.Assemblers.Implementations.AssemblersClientes;
using Microsoft.EntityFrameworkCore;
using io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;
using io.quind.practicaBanco.entity.CuentasEntities;
using io.quind.practicaBanco.data.Assemblers.Implementations.AssemblersCuentas;
using io.quind.practicaBanco.DTO.CuentaDTOS;
using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;
using io.quind.practicaBanco.entity.TransaccionesEntities;
using io.quind.practicaBanco.DTO.TransaccionDTOS;
using io.quind.practicaBanco.domain.Models.Clientes.Services;
using io.quind.practicaBanco.domain.Models.Clientes.Services.Implementations;
using Microsoft.AspNetCore.Rewrite;
using io.quind.practicaBanco.domain.Models.Clientes.Repositories;
using io.quind.practicaBanco.data.Repositories;
using io.quind.practicaBanco.domain.Rules;
using io.quind.practicaBanco.domain.Models.Clientes.RulesImplements;
using io.quind.practicaBanco.domain.Models.Cuentas.Services;
using io.quind.practicaBanco.domain.Models.Cuentas.RulesImplements;
using io.quind.practicaBanco.domain.Models.Cuentas.Services.Implementations;
using io.quind.practicaBanco.domain.Models.Cuentas.Repositories;
using io.quind.practicaBanco.domain.Models.Transacciones.Services;
using io.quind.practicaBanco.domain.Models.Transacciones.Services.Implementations;
using io.quind.practicaBanco.domain.Models.Transacciones.RulesImplements;
using io.quind.practicaBanco.ap.Assemblers.Implementations;
using io.quind.practicaBanco.domain.Models.Transacciones.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BancoEjercicioContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConectarDb"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IAssembler<Cliente,ClienteEntidad>, ClienteEntityAssembler>();
builder.Services.AddTransient<IAssembler<ClienteEntidad,Cliente>, ClienteModelAssembler> ();
builder.Services.AddTransient < IAssembler<ClienteRequestDto, Cliente>, ClienteImpDto>();

builder.Services.AddTransient<IAssembler<Cuenta, CuentaEntidad>, CuentaEntityAssembler>();
builder.Services.AddTransient<IAssembler<CuentaEntidad, Cuenta>, CuentaModelAssembler>();
builder.Services.AddTransient<IAssembler<CuentaRequest, Cuenta>, CuentaImpDto>();

builder.Services.AddTransient<IAssembler<Transaccion, TransaccionEntidad>, TransaccionEntityAssembler>();
builder.Services.AddTransient<IAssembler<TransaccionEntidad,Transaccion>,TransaccionModelAssembler>();
builder.Services.AddTransient<IAssembler<TransaccionRequestDto, Transaccion>, TransaccionImpDto>();

builder.Services.AddTransient<IClienteRepository,ClienteRepository>();
builder.Services.AddTransient<IClienteService, ClienteServiceImp>();
builder.Services.AddTransient<IRuleCliente<Cliente>,RuleCliente>();

builder.Services.AddTransient<ICuentaRepository, CuentaRepository>();
builder.Services.AddTransient<ICuentaService, CuentaServiceImp>();
builder.Services.AddTransient<IRuleCuenta<Cuenta>,RuleCuenta>();

builder.Services.AddTransient<ITransaccionRepository, TransaccionRepository>();
//builder.Services.AddTransient<ITransaccionService, TransaccionServiceImp>();
//builder.Services.AddTransient<IRuleTransaccion<Transaccion>,RuleTransaccion>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
