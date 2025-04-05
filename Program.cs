using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_First.Data;
using MVC_First.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVC_FirstContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVC_FirstContext") ?? throw new InvalidOperationException("Connection string 'MVC_FirstContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/Error/{0}");
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Seed(services);
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
