using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BitacoraAuto3D.Infraestructure.Services
{
    public interface ICatalogServices
    {
        
    }
    
    public class CatalogServices:ICatalogServices
    {
        
    }
    public static class CatalogServicesExtensions
    {
        public static IServiceCollection AddCatalogServices(this IServiceCollection Services){
            Services.AddTransient<ICatalogServices,CatalogServices>();
            return Services;
        }
    }
}