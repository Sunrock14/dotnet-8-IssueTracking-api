using AutoMapper;
using IssueTracking.Data.Contexts;
using IssueTracking.Data.UnitOfWork;
using IssueTracking.Services.Automapper.Profiles;
using IssueTracking.Services.Businesses.Projects;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

namespace IssueTracking.Services.Extensions;
public static class ServiceExtension
{
    private const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
    public static void LoadCustomServices(this IServiceCollection services, IConfiguration configuration)
    {
        //ConnectionString
        var conn = configuration.GetConnectionString("LocalDB");
        services.AddDbContext<IssueTrackingContext>(options => options.UseSqlServer(conn).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));


        //Custom Services
        //services.AddScoped<IUnitOfWork, UnitOfWork>();
        //services.AddScoped<IProjectService, ProjectManager>();

    }
    public static void LoadAutoMapperService(this IServiceCollection services)
    {
        //AutoMapper
        services.AddSingleton(provider => new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new GeneralProfile());
        }).CreateMapper());
    }
    public static void LoadCorsPolicy(this IServiceCollection services, IWebHostEnvironment environment)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
            {
                if (environment.IsProduction())
                {
                    policy.WithOrigins("https://*.IssueTracking.com")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                }
                else
                {
                    policy.WithOrigins("http://localhost:7004", "http://localhost:5177")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                }
            });
        });

    }
    public static void LoadConfigureSwagger(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = configuration.GetSection("OpenApiInfoTitle").Value,
                    Version = configuration.GetSection("OpenApiVersion").Value,
                    Description = configuration.GetSection("OpenApiDescription").Value,
                });
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "bearer",
                BearerFormat = "JWT"
            });
            options.AddSecurityRequirement(new OpenApiSecurityRequirement {
            {
                new OpenApiSecurityScheme{
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
                },
                new string[] { }
            }});
            options.OperationFilter<SecurityRequirementsOperationFilter>();
        });
    }
    public static void LoadConfigureJWTAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        string? secret = configuration.GetSection("Settings:Secret").Value;
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateActor = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
    }
    public static void LoadAppsettingsStatic(this IServiceCollection services, IConfiguration configuration)
    {
        //services.Configure<Settings>(configuration.GetSection("Settings"));
        //services.Configure<Settings>(configuration.GetSection("ExcelPath"));
    }

}
