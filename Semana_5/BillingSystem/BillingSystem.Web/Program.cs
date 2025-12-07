var builder = WebApplication.CreateBuilder(args);

//Services container
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer("Data Source=JEAN_HOLGUIN;Initial Catalog=BillingSystem;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<BillService>();

builder.Services.AddControllersWithViews();


//Middlewares`
var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
