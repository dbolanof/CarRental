﻿using Application.Constants;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repository;


namespace Persistence
{
    /// <summary>
    /// Class to add service extensions
    /// </summary>
    public static class ServiceExtension
    {
        public static IServiceCollection AddPersistenceInfraestructure(this IServiceCollection service, IConfiguration configuration)
        {
            //Register Conection database
            service.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetSection("ConnectionStrings:SqlServerConection").Value));
            //Register generic repository
            service.AddTransient(typeof(IRepositoryAsync<>), typeof(GenericRepository<>));
            return service;
        }
    }
}
