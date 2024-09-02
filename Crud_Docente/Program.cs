using Crud_Docente.data;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//esto lo tengo que sacar del repo
Env.Load();

var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbDatabaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

var mySqlConnection = $"server={dbHost};port={dbPort};database={dbDatabaseName};uid={dbUser};password={dbPassword}";

// hasta aqui va la conexion a las credenciales de la db

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => // es appdbcontext es lo que se modifica
    options.UseMySql(mySqlConnection,ServerVersion.Parse("8.0.20-mysql")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
