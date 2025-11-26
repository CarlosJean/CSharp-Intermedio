using EntradaDiario.BLL.Interfaces;
using EntradaDiario.BLL.Services;
using EntradaDiario.DAL.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace EntradaDiario.WForm
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			var configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
			.Build();

			var services = new ServiceCollection();

			services.AddSingleton<IConfiguration>(configuration);
			services.AddScoped<IDiarioRepositorio>(provider =>
			{
				var configuration = provider.GetRequiredService<IConfiguration>();
				var connectionString = configuration.GetConnectionString("DefaultConnection");
				return new DiarioRepositorio(connectionString);
			});
			services.AddScoped<IDiarioServicio, DiarioServicio>();

			services.AddScoped<Form1>();

			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			var provider = services.BuildServiceProvider();
			Application.Run(provider.GetRequiredService<Form1>());
		}
	}
}