using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitacoraAuto3D.Db.Models.Models;
using BitacoraAuto3D.Infraestructure.DTO;
using Microsoft.Extensions.DependencyInjection;

namespace BitacoraAuto3D.Infraestructure.Services
{
    public interface IProcedureServices
    {
        Task<BaseResult> AddClients(ClientsDTO model);
    }
    public class ProcedureServices:IProcedureServices
    {
        private readonly BITACORA3DContext _bitacoraContext;
        
        public ProcedureServices(BITACORA3DContext bitacora3DContext)
        {
            _bitacoraContext=bitacora3DContext;
        }
        public async Task<BaseResult> AddClients(ClientsDTO model)
        {
            try
            {
                Cliente cliente= new Cliente(){

                Nombre=model.nombre,
                Correo=model.correo,
                Telefono=model.telefono
                };
                await _bitacoraContext.Clientes.AddAsync(cliente);
                _bitacoraContext.SaveChanges();

                return new BaseResult(){ Message="Usuario creado con exito",Saved=true,Error=false};
            }
            catch(Exception ex)
            {
                return new BaseResult(){ Message=$"Ocurrio un problema {ex.Message}",Saved=false,Error=true};
            }

            
        }
    }
    public static class ProcedureServicesExtensions
    {
        public static IServiceCollection AddProcedureServices(this IServiceCollection Services){
            Services.AddTransient<IProcedureServices,ProcedureServices>();
            return Services;
        }
    }
}