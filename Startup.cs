using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using forex_converter_mvc.Services;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;


namespace forex_converter_mvc
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment HostEnvironment { get; }



        public Startup(IConfiguration configuration,IWebHostEnvironment env)
        {
            Configuration = configuration;
            HostEnvironment = env;
        }        



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddHttpClient<ApiCallerService>("SEBclient", client =>
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "<YOUR-API-KEY>");
            });
            services.AddHttpClient<ApiCallerService2>("SEBclient", client =>
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));                
            });
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            if (HostEnvironment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                if (HostEnvironment.IsDevelopment())
                {
                    endpoints.MapGet("config", async context =>
                     {
                         var configInfo = (Configuration as IConfigurationRoot).GetDebugView();
                         await context.Response.WriteAsync(configInfo);
                     });
                }
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Api}/{action=Exchange}/{id?}");
            });
        }
    }
}
