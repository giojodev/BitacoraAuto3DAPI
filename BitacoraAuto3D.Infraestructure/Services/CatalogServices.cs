using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

using BitacoraAuto3D.Db.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BitacoraAuto3D.Infraestructure.Services
{
    public interface ICatalogServices
    {
        Task<List<Cliente>> GetListClients();
    }
    
    public class CatalogServices:ICatalogServices
    {
        private readonly BITACORA3DContext _bitacoraContext;
        
        public CatalogServices(BITACORA3DContext bitacora3DContext)
        {
            _bitacoraContext=bitacora3DContext;
        }
        public async Task<List<Cliente>> GetListClients()
        {
            try
            {
                var clients =  await _bitacoraContext.Clientes.ToListAsync();
                // var clients =  _bitacoraContext.Database.SqlQueryRaw<string>("Select nombre from clientes").ToList();
                return clients;   
            }
            catch(Exception ex)
            {
                string problema= ex.Message;
                var clientes =new List<Cliente>();
                return clientes;


            }
            
        }
    }
    public static class CatalogServicesExtensions
    {
        public static IServiceCollection AddCatalogServices(this IServiceCollection Services){
            Services.AddTransient<ICatalogServices,CatalogServices>();
            return Services;
        }
    }
}