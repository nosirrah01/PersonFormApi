using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Text;
using PersonFormApi.Data;
using Microsoft.EntityFrameworkCore;

namespace PersonFormApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<PersonDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            // Serve static files and set the default file to index.html
            app.UseDefaultFiles();
            app.UseStaticFiles(new StaticFileOptions
            { 
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")),
                RequestPath = ""
            });

            app.UseAuthorization();

            app.MapControllers();

            app.MapGet("/", async context =>
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html");
                var fileBytes = await File.ReadAllBytesAsync(filePath);
                await context.Response.Body.WriteAsync(fileBytes, new CancellationToken());
            });

            app.Run();
        }
    }
}