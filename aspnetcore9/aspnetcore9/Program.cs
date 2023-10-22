using aspnetcore9.Controllers;
using aspnetcore9.Data;
using aspnetcore9.Models;
using aspnetcore9.Services;
using aspnetcore9.Validations;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System.Reflection;
using System.Net.NetworkInformation;

namespace aspnetcore9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(op =>
                op.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext")));
            builder.Services.AddAutoMapper(typeof(Program).Assembly);
            //builder.Services.AddScoped<LaptopService>();
            builder.Services.AddScoped<SmartphoneService>();
            builder.Services.AddScoped<ProductService>();
            builder.Services.AddScoped<IValidator<Product>, ProductValidator>();
            
            builder.Services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

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
        }
    }
}