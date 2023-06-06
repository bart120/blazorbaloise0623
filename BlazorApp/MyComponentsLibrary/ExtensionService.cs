using Microsoft.Extensions.DependencyInjection;
using MyComponentsLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComponentsLibrary
{
    public static class ExtensionService
    {
        public static IServiceCollection AddToastServices(this IServiceCollection services)
        {
            services.AddScoped<ToastService>();
            return services;
        }
    }
}
