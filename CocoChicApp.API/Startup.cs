using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocoChicApp.API.Helpers;
using CocoChicApp.API.Services;
using CocoChicApp.API.Services.Interfaces;
using CocoChicApp.Business.Interfaces;
using CocoChicApp.Business.Services;
using CocoChicApp.EF.Models;
using CocoChicApp.EF.Repositories;
using CocoChicApp.EF.Repositories.Interfaces;
using CocoChicApp.Mapping;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using Microsoft.Extensions.Configuration;

namespace CocoChicApp.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            //services.AddCors(
            //      options => options.AddPolicy(
            //          MyAllowSpecificOrigins,
            //          builder => builder
            //              .AllowAnyOrigin()
            //              .AllowAnyHeader()
            //              .AllowAnyMethod()
            //              .AllowCredentials()
            //      )
            //  );

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            var connection = @"data source=.\SQLEXPRESS;initial catalog=BeautyPro_COCO;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            //var connection = @"data source=WIN-6R9O3VJP2Q1;initial catalog=COCOTempMobileApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            //var connection = @"Server=WIN-6R9O3VJP2Q1;Database=COCOTempMobileApp;Trusted_Connection=True;";
            services.AddDbContext<BeautyPro_COCOContext>(options => options.UseSqlServer(connection));

            //services.AddIdentity<IdentityUser, IdentityRole>()
            //    .AddEntityFrameworkStores<ChristellOfficeContext>();

            services.AddMvc(options => options.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(opt => opt.SerializerSettings.ContractResolver = new DefaultContractResolver());

            //services.AddScoped<IJwtFactory, JwtFactory>();

            //To DO
            //Repositories
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IConsentFormDailyRepository, ConsentFormDailyRepository>();
            services.AddScoped<IConsentFormDailyService, ConsentFormDailyService>();

            services.AddScoped<IConsentFormInitiRepository, ConsentFormInitiRepository>();
            services.AddScoped<IConsentFormInitService, ConsentFormInitService>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();

            services.AddScoped<ITreatmentDailyUpdatePhotosRepository, TreatmentDailyUpdatePhotosRepository>();
            //services.AddScoped<ITreatmentDailyUpdatePhotosService, TreatmentDailyUpdatePhotosService>();

            services.AddScoped<ITreatmentDailyUpdateRepository, TreatmentDailyUpdateRepository>();
            services.AddScoped<ITreatmentDailyUpdateService, TreatmentDailyUpdateService>();

            services.AddScoped<IUserInfoRepository, UserInfoRepository>();
            services.AddScoped<IUserInfoService, UserInfoService>();

            services.AddScoped<IEmployeeDetailRepository, EmployeeDetailRepository>();
            services.AddScoped<IEmployeeDetailService, EmployeeDetailService>();

            services.AddScoped<IUserService, UserService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            AutoMapperRegistry.CreateMappings();
            app.UseAuthentication();
            //To DO
            //Authentication

            app.UseCors(c =>
            {
                c.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
            });

            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "UserImages/Signatures")),
                RequestPath = "/UserImages/Signatures"
            });

            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "UserImages/Signatures")),
                RequestPath = "/UserImages/Signatures"
            });

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "UserImages/Treatment")),
                RequestPath = "/UserImages/Treatment"
            });

            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "UserImages/Treatment")),
                RequestPath = "/UserImages/Treatment"
            });

            app.UseMvc();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
