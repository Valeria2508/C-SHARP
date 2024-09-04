using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Taller.Controllers.v1.propietarios
{   
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PropietariosController : ControllerBase
    {

        private readonly ApplicationDbContext context;

        public PropietariosController (ApplicationDbContext conexionDB)
        {
            ConexionDB = conectionDB;
        }

        [HttpGet]
        public async Task<IActionResult> Get(){
            return Ok("hola mundo");
        }
    
    }
}