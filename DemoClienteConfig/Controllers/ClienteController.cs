using DemoClienteConfig.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DemoClienteConfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ParametroConfig options;

        public ClienteController(IOptions<ParametroConfig> options)
        {
            this.options = options.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(options);
        }
    }
}