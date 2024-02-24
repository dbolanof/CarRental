using Application.Behavior;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// Registro de de los ensamblados de referencia para utilizar lo nugets
        /// </summary>
        /// <param name="services"></param>
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            // Register assembly Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //Register assembly validator
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // Register assembly MediaTR
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //Register Pipe line to validation behavior
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            return services;
        }
    }
}
