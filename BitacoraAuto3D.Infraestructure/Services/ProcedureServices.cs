using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BitacoraAuto3D.Infraestructure.Services
{
    public interface IProcedureServices
    {
        
    }
    public class ProcedureServices:IProcedureServices
    {

    }
    public static class ProcedureServicesExtensions
    {
        public static IServiceCollection AddProcedureServices(this IServiceCollection Services){
            Services.AddTransient<IProcedureServices,ProcedureServices>();
            return Services;
        }
    }
}