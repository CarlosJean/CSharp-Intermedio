using BillingSystem.Core.Interfaces;
using BillingSystem.Web.Controllers;

var builder = WebApplication.CreateBuilder(args);

//Services container
var connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseSqlServer(connectionString));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IBillService, BillService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddControllersWithViews();

//Middlewares`
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Customers}/{action=Index}/{id?}");

app.Run();