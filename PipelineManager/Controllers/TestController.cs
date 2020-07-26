#if DEBUG

namespace PipelineManager.Controller
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult ExtractPs()
        {
            var res = PowerShell.InvokeFile(@"scripts\test.ps1");

            return StatusCode(res.Ok ? 200 : 500, res);
        }
    }
}

#endif
