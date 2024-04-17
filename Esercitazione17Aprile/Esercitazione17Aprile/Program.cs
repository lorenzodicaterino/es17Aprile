using Esercitazione17Aprile.Models;
using Esercitazione17Aprile.Repository;
using Esercitazione17Aprile.Service;
using Esercitazione17Aprile.Services;
using Microsoft.EntityFrameworkCore;

namespace Esercitazione17Aprile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<Esercitazione17AprileContext>(
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("Locale")
                    )
                );
            builder.Services.AddScoped<RepartoRepository>();
            builder.Services.AddScoped<RepartoService>();
            builder.Services.AddScoped<ImpiegatoRepository>();
            builder.Services.AddScoped<ImpiegatoService>();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Impiegato}/{action=Inserimento}/{id?}");

            app.Run();
        }
    }
}
