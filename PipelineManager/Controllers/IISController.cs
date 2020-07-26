using Microsoft.AspNetCore.Mvc;

namespace PipelineManager.Controller
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class IISController : ControllerBase
    {
        [HttpGet("sites/stop")]
        public IActionResult StopSites()
        {
            var res = IIS.StopSites();

            return StatusCode(res.Ok ? 200 : 500, res);
        }

        [HttpGet("sites/start")]
        public IActionResult StartSites()
        {
            var res = IIS.StartSites();

            return StatusCode(res.Ok ? 200 : 500, res);
        }

        [HttpGet("sites/appoffline/add")]
        public IActionResult AddAppOffline()
        {
            var res = IIS.AddAppOffline();

            return StatusCode(res.Ok ? 200 : 500, res);
        }

        [HttpGet("sites/appoffline/remove")]
        public IActionResult RemoveAppOffline()
        {
            var res = IIS.RemoveAppOffline();

            return StatusCode(res.Ok ? 200 : 500, res);
        }
    }
}
