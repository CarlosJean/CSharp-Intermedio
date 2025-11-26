using EntradaDiario.BLL.Interfaces;
using EntradaDiario.BLL.Services;
using EntradaDiario.DAL.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

//Configuring services
var configuration = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
.Build();

var services = new ServiceCollection();

services.AddSingleton<IConfiguration>(configuration);
services.AddScoped<IDiarioRepositorio>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    string? connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";
    return new DiarioRepositorio(connectionString);
});
services.AddScoped<IDiarioServicio, DiarioServicio>();


var provider = services.BuildServiceProvider();
var repositorio = provider.GetRequiredService<IDiarioServicio>();
//End configuring services


Console.WriteLine("Seleccione una opción:\n\n 1. Agregar nueva entrada\n 2. Actualizar una entrada\n 3. Consultar una entrada\n 4. Remover una entrada\n 5. Ver todas las entradas");
Console.WriteLine("Opción: ");
int opcion = Convert.ToInt32(Console.ReadLine());

string fecha = "";
string titulo = "";
string contenido = "";

EntradaDiario.Entities.EntradaDiario? entradaDiario = new();

switch (opcion)
{
    case 1:
        Console.Write("Introduzca la fecha: ");
        fecha = Console.ReadLine() ?? DateTime.Now.ToShortDateString();

        Console.WriteLine("Introduzca el título: ");
        titulo = Console.ReadLine() ?? "";

        Console.WriteLine("Introduzca el contenido: ");
        contenido = Console.ReadLine() ?? "";

        entradaDiario = new()
        {
            Titulo = titulo,
            Contenido = contenido,
            Fecha = Convert.ToDateTime(fecha),
        };

        repositorio.AgregarEntrada(entradaDiario);
        break;
    case 2:
        Console.Write("Introduzca el id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduzca la fecha: ");
        fecha = Console.ReadLine() ?? DateTime.Now.ToShortDateString();

        Console.WriteLine("Introduzca el título: ");
        titulo = Console.ReadLine() ?? "";

        Console.WriteLine("Introduzca el contenido: ");
        contenido = Console.ReadLine() ?? "";

        entradaDiario = new()
        {
            Id = id,
            Titulo = titulo,
            Contenido = contenido,
            Fecha = Convert.ToDateTime(fecha),
        };

        repositorio.ActualizarEntrada(entradaDiario);
        break;
    case 3:
        Console.Write("Introduzca el id: ");
        id = Convert.ToInt32(Console.ReadLine());

        entradaDiario = repositorio.ObtenerEntradaPorId(id);

        if (entradaDiario == null)
        {
            Console.WriteLine("La entrada buscada no se encontró.");
            return;
        }

        Console.WriteLine($"Id: {entradaDiario?.Id}\nTítulo: {entradaDiario?.Titulo}\nContenido: {entradaDiario?.Contenido}\nFecha: {entradaDiario?.Fecha}");

        break;
    case 4:
        try
        {
            Console.Write("Introduzca el id: ");
            id = Convert.ToInt32(Console.ReadLine());

            repositorio.EliminarEntrada(id);
        }
        catch (System.Exception)
        {
            Console.WriteLine($"Hubo un error al intentar remover la entrada con el ID especificado.");
        }
        break;

    case 5:
        List<EntradaDiario.Entities.EntradaDiario> entradas = repositorio.ObtenerTodasLasEntradas();

        foreach (EntradaDiario.Entities.EntradaDiario entrada in entradas)
        {
            Console.WriteLine($"ID: {entrada.Id}\tTitulo: {entrada.Titulo}\tContenido: {entrada.Contenido}\tFecha: {entrada.Fecha}\t Fecha creación: {entrada.FechaCreacion}");
        }
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}