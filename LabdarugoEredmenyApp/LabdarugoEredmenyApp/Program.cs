using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LabdarugoEredmenyApp.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LabdarugoEredmenyekContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LabdarugoEredmenyekContext") ?? throw new InvalidOperationException("Connection string 'LabdarugoEredmenyekContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bajnoksagok}/{action=Index}/{sortDate?}");

app.Run();
