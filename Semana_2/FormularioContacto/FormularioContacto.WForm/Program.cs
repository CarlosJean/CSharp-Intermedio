using FormularioContacto.BLL;
using FormularioContacto.DAL.Contexts;
using FormularioContacto.DAL.Interfaces;
using FormularioContacto.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FormularioContacto.WForm {
	internal static class Program {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {


			var configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
			.Build();


			var services = new ServiceCollection();

			services.AddScoped<IContactService, ContactsService>();
			services.AddScoped<IContactsRepository, ContactsRepository>();
			services.AddScoped<Form1>();

			ConfigureServices(services);

			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			var provider = services.BuildServiceProvider();
			Application.Run(provider.GetRequiredService<Form1>());
		}

		private static void ConfigureServices(ServiceCollection services) {

			var configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
			.Build();

			var connectionString = configuration.GetConnectionString("DefaultConnection");

			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(connectionString, x => x.MigrationsAssembly("FormularioContacto.DAL")));

		}

	}
}