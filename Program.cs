using HJNKoyil.Areas.Identity;
using HJNKoyil.Data;
using HJNKoyil.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using HJNKoyil.Controllers;

namespace HJNKoyil
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            var connectionString1 = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            //builder.Services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(connectionString));

            builder.Services.AddDbContext<KoyilDbContext>(options =>
                options.UseSqlServer(connectionString1));


            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            

            //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<KoyilDbContext>();

            builder.Services.AddControllers();

            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddSingleton<HJNKoyil.Controllers.CommonMasterController>();
            builder.Services.AddSingleton<CommonMasterDtlController>();
            builder.Services.AddSingleton<VwCommonMasterDtl>();
            builder.Services.AddSingleton<CommonMasterDtl>();
            builder.Services.AddSingleton<IndividualController>();
            builder.Services.AddSingleton<vwDonationController>();
            builder.Services.AddSingleton<vwExpenseController>();
            builder.Services.AddSingleton<vwCommonMasterDtlController>();
            builder.Services.AddSingleton<DonationController>();
            builder.Services.AddSingleton<ExpenseController>();
            builder.Services.AddSingleton<vwAppUserController>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}
