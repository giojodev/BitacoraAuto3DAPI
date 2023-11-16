using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BitacoraAuto3D.Db.Models.Models;
using BitacoraAuto3D.Infraestructure.Services;
using BitacoraAuto3D.Infraestructure.DTO;

namespace BitacoraAuto3DAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Bitacora3DController : ControllerBase
    {
        
        private readonly ICatalogServices _catalogservices;
        private readonly IProcedureServices _procedureservices;
        private readonly ILogger<Bitacora3DController> _logger;

        public Bitacora3DController(ICatalogServices catalogServices,IProcedureServices procedureServices,ILogger<Bitacora3DController>logger)
        {
            _catalogservices=catalogServices;
            _procedureservices=procedureServices;
            _logger=logger;
        }
        
        [HttpGet("Catalog/ListClients")]
        public async Task<IActionResult> GetClients()
        {           
            var response = await _catalogservices.GetListClients();
            return Ok(response);
        }
        [HttpPost("Procedure/AddClients")]
        public async Task<IActionResult> AddClients(ClientsDTO model)
        {
            var result = await _procedureservices.AddClients(model);
            if(result.Error)
                return BadRequest(result.Message);
            return Ok(result);
        }

    }
}