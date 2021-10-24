using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using BL.Repositories;
using BL.Repositories.Implements;
using BL.Services;
using BL.Services.Implements;
using System.Reflection;

namespace BL.DATA
{
    public static class ServiceExtension
    {
        public static IServiceCollection RegisterMyServices(this IServiceCollection services)
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            InyectDependency(services, "BL.Repositories.Implements", "Repository");

            InyectDependency(services, "BL.Services.Implements", "Service");

            return serviceCollection;
        }

        private static void InyectDependency(IServiceCollection services, string namespaceName, string resourceName)
        {
            Assembly asmSer = Assembly.GetExecutingAssembly();
            List<Type> typesSer = asmSer.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.Namespace == namespaceName && t.Name.Contains(resourceName))
                .ToList();

            foreach (Type tSer in typesSer)
            {
                var miClaseType = tSer.GetType();
                var miClaseName = tSer.Name;
                var interfaces = tSer.GetInterfaces();
                string miClaseInterface = interfaces[1].Name;

                Type tInt = tSer.GetInterface(miClaseInterface);


                services.AddTransient(tInt, tSer);
            }

        }
    }
}
