﻿using Microsoft.Extensions.DependencyInjection;
using ServicesLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary
{
    public static class ExtensionService
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddScoped<CarsService>();
            services.AddScoped<BrandsService>();
            return services;
        }
    }
}
