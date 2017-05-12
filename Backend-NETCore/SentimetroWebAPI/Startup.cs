using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using SentimetroWebAPI.Context;
using SentimetroWebAPI.Contracts;
using SentimetroWebAPI.Repositories;

namespace SentimetroWebAPI
{
    public class Startup
    {
        
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddMvc();
            var connectionString = this.Configuration["connectionStrings:voteDbConnectionString"];
            //var connectionString = @"Server=(localdb)\mssqllocaldb;Database=Sentimetro;Trusted_Connection=True;";//@"Server=tcp:sentimetro.database.windows.net,1433;Initial Catalog=Sentimetro;Persist Security Info=False;User ID=xavism;Password=Sk8andsnow;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            services.AddDbContext<VoteDbContext>(o => o.UseSqlServer(connectionString));

            services.AddScoped<IVotesRepository, VotesRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseCors("CorsPolicy");
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            app.UseStatusCodePages();
            app.UseMvc();
            
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entities.Vote, Models.VoteViewModel>();
                cfg.CreateMap<Models.VoteViewModel, Entities.Vote>();
            });
        }
    }
}
