using Agiary.Domain.System;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Agiary.Server.Controllers
{
    [Route("api/modules")]
    [ApiController]
    public class ModuleController
    {
        public readonly SystemContext context;

        public ModuleController(SystemContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => new OkObjectResult(await context.Modules.ToListAsync());
    }
}
