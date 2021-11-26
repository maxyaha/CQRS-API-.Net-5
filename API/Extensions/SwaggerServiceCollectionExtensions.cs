﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace API.Extensions
{
    public static class SwaggerServiceCollectionExtensions
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Max Project",
                    Description = "Max API Swagger surface",
                    Contact = new OpenApiContact { Name = "Max", Email = "contato@eduardopires.net.br", Url = new Uri("http://www.google.com") },
                    License = new OpenApiLicense { Name = "Max", Url = new Uri("http://www.google.com") }
                });

                //options.AddSecurityDefinition("Bearer", new ApiKeyScheme { Name = "ApiUserToken", In = "header", Type = "apiKey", Description = "JWT Authorization header using the Bearer scheme. Example: \"{token}\"" });
                //options.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>> { { "Bearer", new string[] { } } });
                s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"{token}\"",
                    Name = "ApiUserToken",
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
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

        public static void UseSwaggerSetup(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                c.DocumentTitle = "API Documentation";
                c.DocExpansion(DocExpansion.List);
            });
        }
    }
}