using System;
using Microsoft.AspNetCore.Mvc;

namespace LineDeployBot.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class LineChatController : ControllerBase {

        public LineChatController() {}

        [HttpGet]
        public ActionResult<dynamic> Test() {
            return new { status = "ok" };
        }
    }
}