using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LabdarugoEredmenyApp.Data;
using Microsoft.Extensions.Options;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LabdarugoEredmenyekContext>(options => options.UseMySql("server=;database=;user=;password=;GuidFormat=Binary16", ServerVersion.AutoDetect("server=;database=;user=;password=;GuidFormat=Binary16")));

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
