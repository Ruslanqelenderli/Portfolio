using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Online_Sales;
using Online_Sales.EmailServices;
using Online_Sales.İdentity;
using OnlineSalesBusiness.Abstract;
using OnlineSalesBusiness.Concrete;
using OnlineSalesData.Abstract;
using OnlineSalesData.Concrete.EFCore;
using OnlineSalesDatas.Abstract;
using OnlineSalesDatas.Concrete.EFCore;
using System;

namespace Online_Sales
{
    public class Startup
    {
        private IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        

        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer("Data Source = DESKTOP-7E9NEVO; Initial Catalog = OSDb; Integrated Security = SSPI; MultipleActiveResultSets=true"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddScoped<IProductRepository, EFCoreProductRepository>();
            services.AddScoped<IProductService, ProductManager>();


            services.AddScoped<ICartRepository, EFCoreCartRepository>();
            services.AddScoped<ICartService, CartManager>();


            services.AddScoped<ICategoryRepository, EFCoreCategoryRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();



            services.AddScoped<IEmailSender, SmtpEmailSender>(i=>
            new SmtpEmailSender(
                    Configuration["EmailSender:Host"],
                    Configuration.GetValue<int>("EmailSender:Port"),
                    Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    Configuration["EmailSender:UserName"],
                    Configuration["EmailSender:Password"]
                )
            );

            services.Configure<IdentityOptions>(options => {
                // password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;

                // Lockout                
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options => {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".Online_Sales.Security.Cookie",
                    SameSite=SameSiteMode.Strict
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseRequestLocalization();

            app.UseMvc();

            
            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();






            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "cart",
                   pattern: "cart",
                   defaults: new { controller = "Cart", action = "Index" }
               );


                endpoints.MapControllerRoute(
                   name: "useredit",
                   pattern: "user/edit/{id?}",
                   defaults: new { controller = "UserRole", action = "EditUser" }
               );



                endpoints.MapControllerRoute(
                   name: "userlist",
                   pattern: "user/list",
                   defaults: new { controller = "UserRole", action = "UserList" }
               );



                endpoints.MapControllerRoute(
                   name: "roleedit",
                   pattern: "role/edit/{id?}",
                   defaults: new { controller = "UserRole", action = "EditRole" }
               );


                endpoints.MapControllerRoute(
                   name: "rolelist",
                   pattern: "role/list",
                   defaults: new { controller = "UserRole", action = "RoleList" }
               );

                endpoints.MapControllerRoute(
                    name: "createrole",
                    pattern: "role/create",
                    defaults: new { controller = "UserRole", action = "CreateRole" }
                );



                endpoints.MapControllerRoute(
                    name: "categoryupdate",
                    pattern: "category/update/{id?}",
                    defaults: new { controller = "Category", action = "Update" }
                );


                endpoints.MapControllerRoute(
                    name: "categoryremove",
                    pattern: "category/remove",
                    defaults: new { controller = "Category", action = "Remove" }
                );



                endpoints.MapControllerRoute(
                    name: "categorycreate",
                    pattern: "category/create",
                    defaults: new { controller = "Category", action = "CreateCategory" }
                );

                endpoints.MapControllerRoute(
                    name: "adminedit",
                    pattern: "admin/product/create",
                    defaults: new { controller = "Admin", action = "CreateProduct" }
                );

                endpoints.MapControllerRoute(
                    name: "adminedit",
                    pattern: "admin/product/edit/{id?}",
                    defaults: new { controller = "Admin", action = "Edit" }
                );

                endpoints.MapControllerRoute(
                    name: "adminproduct",
                    pattern: "admin/product",
                    defaults: new { controller = "Admin", action = "GetAll" }
                );


                endpoints.MapControllerRoute(
                    name: "search",
                    pattern: "search",
                    defaults: new { controller = "Product", action = "search" }
                );

                endpoints.MapControllerRoute(
                    name: "products",
                    pattern: "product/{category?}",
                    defaults: new { controller = "Product", action = "list" }
                );



                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
