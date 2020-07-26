using Microsoft.AspNetCore.Mvc;

namespace PipelineManager.Controller
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ZipController : ControllerBase
    {
        //[HttpGet("extract")]
        //public IActionResult Extract()
        //{
        //    var commandResult = Zip.Extract(
        //        @"C:\Users\a.fathi\Downloads\desktop.zip",
        //        @"C:\Users\a.fathi\Downloads\desktop2"
        //    );

        //    return Ok(new
        //    {
        //        Status = "done",
        //        Message = commandResult,
        //    });
        //}

        [HttpGet("extract/ps")]
        public IActionResult ExtractPs()
        {
            var res = Zip.ExtractPS();

            return StatusCode(res.Ok ? 200 : 500, res);
        }
    }
}
