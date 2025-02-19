using CareYourSkin.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSession(Options => { Options.IdleTimeout = TimeSpan.FromSeconds(60); });
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SkinCareManagementContext>(
    Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("SkinCareManagementContext"))
    );
var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();

app.UseAuthorization();


app.MapControllerRoute("default", "{controller=Home}/{action=Home}/{id?}");

app.Run();