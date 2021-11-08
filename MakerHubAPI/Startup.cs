using MakerHubAPI.DAL;
using MakerHubAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MakerHubAPI {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            services.AddControllers();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MakerHubAPI", Version = "v1" });
            });

            //CORS (Règles d'accessibilité à l'API)
            services.AddCors(options => options.AddPolicy("default", builder => {
                builder.WithOrigins("http://localhost:4200"); //API Privée
                //builder.AllowAnyOrigin(); //API Publique
                //builder.WithMethods("GET"); //Autorise seulement la lecture
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            }));
            services.AddCors(options => options.AddPolicy("default", builder => {
                builder.WithOrigins("http://localhost:8100");
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            }));

            services.AddDbContext<CTTDBContext>();
            
            services.AddScoped<JoueurService>();
            services.AddScoped<AnnonceService>();
            services.AddScoped<CategorieInterclubsService>();
            services.AddScoped<ClassementService>();
            services.AddScoped<EquipeService>();
            services.AddScoped<SouperService>();
            services.AddScoped<StageService>();
            services.AddScoped<TypeSouperService>();
            services.AddScoped<CategorieAgeService>();
            services.AddScoped<ClubService>();
            services.AddScoped<MatchService>();

            services.AddScoped<HttpClient>(b => new HttpClient { BaseAddress = new Uri("http://localhost:3004") });

            services.AddScoped<ClubService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MakerHubAPI v1"));
            }

            app.UseCors("default");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
