using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwingQuestBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostingStatusController : ControllerBase
    {
        private static bool _isHosting = false;

        [HttpGet]
        public ActionResult<bool> GetHostingStatus()
        {
            return Ok(_isHosting);
        }

        [HttpPut]
        public ActionResult SetHostingStatus([FromBody] bool isHosting)
        {
            _isHosting = isHosting;
            return Ok(new { IsHosting = _isHosting });
        }
    }
}
