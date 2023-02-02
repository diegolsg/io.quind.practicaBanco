using io.quind.practicaBanco.data.DBContexts;
using io.quind.practicaBanco.data.Repositories;
using io.quind.practicaBanco.domain.Service;
using Microsoft.EntityFrameworkCore;

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
builder.Services.AddTransient<ICuentaService, CuentaRepository>();
builder.Services.AddTransient<IClienteService, ClienteRepository>();

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
