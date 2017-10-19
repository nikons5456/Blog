using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Blog.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Blog.IDAL.IRespository.User;
using Blog.DAL.Respository.User;
using Blog.Service.User;
using System;
using Blog.IDAL.Repository.Passage;
using Blog.DAL.Respository.Passage;
using Blog.Service.Passage;

namespace Blog.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>(options => options.UseSqlServer("DefaultConnection"),ServiceLifetime.Scoped);
            services.AddMvc();

            //添加IDistributedCache的默认内存实现
            services.AddDistributedMemoryCache();
            //配置Session服务
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
            });
            //注入仓储
            services.AddScoped<IUserRespository, UserRespository>();
            services.AddScoped<IPassageRepository, PassageRepository>();
            
            //注入服务
            services.AddScoped<IUserAppService,UserAppService>();
            services.AddScoped<IPassageAppService, PassageAppService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //使用Session,该方法必须放在前面，否则MVC中使用Session会报错：未配置Session
            app.UseSession();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
