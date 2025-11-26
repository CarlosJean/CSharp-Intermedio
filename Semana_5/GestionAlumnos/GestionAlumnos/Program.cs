using GestionAlumnos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionString =
	builder.Configuration.GetConnectionString("DefaultConnection")
		?? throw new InvalidOperationException("Connection string"
		+ "'DefaultConnection' not found.");

builder.Services.AddDbContextPool<ApplicationDbContext>(
					options => options.UseSqlServer(connectionString));

var app = builder.Build();


app.UseStaticFiles();

app.MapControllerRoute( // Configures conventional routing for MVC
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
