using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Services;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using CleanArch.Infra.Data.Repository;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //application Layer
            services.AddScoped<ICourseService, CourseService>();

            //infra.Data.Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
