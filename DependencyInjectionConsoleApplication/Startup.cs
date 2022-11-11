using DependencyInjectionConsoleApplication.Interfaces;
using DependencyInjectionConsoleApplication.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConsoleApplication
{
    public static class Startup
    {
        public static IHost RegisterServices()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((services) =>
                {
                    services.AddSingleton<IPerson, Person>();
                })
                .Build();

            return host;
        }
    }
}
