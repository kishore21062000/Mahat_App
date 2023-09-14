using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using  Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using Microsoft.OpenApi.Models;
namespace DineandDiscover
{
		public class Startup
		{
			public Startup(IConfiguration configuration, IWebHostEnvironment env, IServiceProvider serviceProvider)
			{
				Configuration = configuration;
				var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);
				//var mvcBuilder = serviceProvider.GetService<IMvcBuilder>();
				//new MvcConfiguration().ConfigureMvc(mvcBuilder);
				Configuration = builder.Build();
		}
			public IConfiguration Configuration { get; }
			public void ConfigureServices(IServiceCollection services)
			{
//Please remove comment from below line if you wish to see the changes of razor files immediately
//services.AddRazorPages().AddRazorRuntimeCompilation();
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
			.AddJwtBearer(options =>
			 {
			options.TokenValidationParameters = new TokenValidationParameters
			{
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidateLifetime = true,
			ValidateIssuerSigningKey = true,
			ValidIssuer = Configuration["ValidIssuer"],
			ValidAudience = "yourdomain.com",
			 IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["SecurityKey"]))
			};
			});
				services.Configure<ConnectionSettings>(Configuration.GetSection("ConnectionSettings"));
				services.Configure<ApiSettings>(Configuration.GetSection("ApiSettings"));
				services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
				services.AddDistributedMemoryCache();
				services.AddSession(options =>
				{
					options.IdleTimeout = TimeSpan.FromMinutes(60);
				});
				services.Configure<IISOptions>(options =>
				{
				});
				services.AddCors().AddMvc().AddFluentValidation()
				.AddNewtonsoftJson(options =>
				{
				options.SerializerSettings.ContractResolver = new DefaultContractResolver();
				});
services.AddSwaggerGen(s =>
        {
            s.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "DineandDiscover",
                Description = "DineandDiscover Apis",
 
            });

            s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "JWT Authorization header using the Bearer scheme (Example: 'Bearer 12345abcdef')",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer"
            });

            s.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
            });
			});
		}
			public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
			{
				app.UseStaticFiles();
				if (env.IsDevelopment())
				{
					app.UseDeveloperExceptionPage();
				}
				else
				{
					app.UseExceptionHandler("/Home/Error");
				}
				app.UseSession();
				app.UseAuthentication();
			app.UseMiddleware<ErrorLoggingMiddleware>();
if (env.IsProduction())
{
app.Use((context, next) =>
{
context.Request.PathBase = "/DineandDiscover/";
return next();
});
}
			app.Use(async (context, next) =>
				{
					context.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
					context.Response.Headers.Add("X-Xss-Protection", "1");
					context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
					await next();
				});
			app.UseForwardedHeaders(new ForwardedHeadersOptions
				{
				ForwardedHeaders = ForwardedHeaders.XForwardedFor |
				ForwardedHeaders.XForwardedProto
				});
				app.UseCors(
				options => options.AllowAnyOrigin()
				.AllowAnyMethod()
				.AllowAnyHeader()
				);
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
endpoints.MapControllerRoute("area", "{area:exists}/{controller=users}/{action=Login}/{id?}");
endpoints.MapControllerRoute(
name: "default",
pattern: "{controller=users}/{action=Login}/{id?}");
});
if(env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "DineandDiscover");
                    c.RoutePrefix = "";

                });
            }
            else
            {
                    var basePath = "/DineandDiscover";
                    app.UseSwagger(c =>
                    {
                    c.SerializeAsV2 = true;
                    c.RouteTemplate = "swagger/{documentName}/swagger.json";
                    c.PreSerializeFilters.Add((swaggerDoc, httpReq) =>
                    {
                    swaggerDoc.Servers = new List<OpenApiServer> { new OpenApiServer { Url = $"https://{httpReq.Host.Value}{basePath}" } };
                    });
                    });
                    app.UseSwaggerUI(c =>
                    {
	                    c.RoutePrefix = "";
	                    c.SwaggerEndpoint("/DineandDiscover/swagger/v1/swagger.json", "DineandDiscover");
                    });
                
            }
			}
		}
}

