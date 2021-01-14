using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Mentrello.API.Managers;
using Mentrello.API.Settings;
using Mentrello.Data;
using Mentrello.Data.Repositories;
using Mentrello.Domain.Repositories;
using Mentrello.Services.Adapters;
using Mentrello.Services.Implementations;
using Mentrello.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;

namespace Mentrello.API
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
            var googleAuthSettings = Configuration.GetSection(GoogleAuthSettings.SectionName).Get<GoogleAuthSettings>();
            var jwtTokenSettings = Configuration.GetSection(JwtTokenSettings.SectionName).Get<JwtTokenSettings>();

            //services.AddSingleton(googleAuthSettings);
            //services.AddSingleton(jwtTokenSettings);
            services.Configure<JwtTokenSettings>(Configuration.GetSection(JwtTokenSettings.SectionName));

            services.AddControllers();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.RequireHttpsMetadata = true;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = jwtTokenSettings.Issuer,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtTokenSettings.Secret)),
                        ValidateAudience = true,
                        ValidAudience = jwtTokenSettings.Audience,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.FromDays(1)
                    };
                    options.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = async context => 
                        {
                            var accessToken = context.SecurityToken as JwtSecurityToken;
                        },
                        OnMessageReceived = async context =>
                        {
                            var token = context.Token;
                        }
                    };
                })
                .AddGoogle("Google", options =>
                {
                    options.AuthorizationEndpoint = googleAuthSettings.AuthUrl;
                    options.ClientId = googleAuthSettings.ClientId;
                    options.ClientSecret = googleAuthSettings.ClientSecret;
                    options.CallbackPath = googleAuthSettings.CallbackPath;
                    
                    var serviceProvider = services.BuildServiceProvider();
                    options.Events = serviceProvider.GetRequiredService<AuthManager>();
                    options.SaveTokens = true;
                });

            services.AddAuthorization(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme)
                .RequireAuthenticatedUser()
                .Build();
            });

            #region Services

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserAdapter, UserAdapter>();
            services.AddScoped<AuthManager>();
            #endregion

            #region Repositories

            services.AddScoped<IBoardRepository, BoardRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            #endregion

            services.AddDbContext<MentrelloContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "Mentrello API");
            });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
