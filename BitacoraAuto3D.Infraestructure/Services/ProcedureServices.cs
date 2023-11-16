using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitacoraAuto3D.Db.Models.Models;
using BitacoraAuto3D.Infraestructure.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BitacoraAuto3D.Infraestructure.Services
{
    public interface IProcedureServices
    {
        Task<BaseResult> AddClients(ClientsDTO model);
        Task<BaseResult> UpdateClients(UpdateClientDTO model);
    }
    public class ProcedureServices:IProcedureServices
    {
        private readonly BITACORA3DContext _bitacoraContext;
        private readonly ILogger<IProcedureServices> _logger;
        
        public ProcedureServices(BITACORA3DContext bitacora3DContext,ILogger<IProcedureServices> logger)
        {
            _bitacoraContext=bitacora3DContext;
            _logger=logger;
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
                _logger.LogError("Error al añadir cliente",ex);
                return new BaseResult(){ Message=$"Ocurrio un problema {ex.Message}",Saved=false,Error=true};
            }

            
        }
        public async Task<BaseResult> UpdateClients(UpdateClientDTO model)
        {
            try
            {
                var user= await _bitacoraContext.Clientes.Where(x=>x.IdCliente==model.idCliente).FirstAsync();
                if(user==null)
                    return new BaseResult(){ Message="No fue encontrado el cliente",Saved=false,Error=true};
                
                user.Nombre=model.nombre;
                user.Telefono=model.telefono;
                user.Correo=model.correo;
                _bitacoraContext.Entry(user).State=EntityState.Modified;
                await _bitacoraContext.SaveChangesAsync();

                return new BaseResult(){ Message="Usuario actualizado con exito",Saved=true,Error=false};
            }
            catch(Exception ex)
            {
                _logger.LogError("Error al actualizar cliente",ex);
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