using System;
using Microsoft.AspNetCore.Mvc;

namespace LineDeployBot.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class LineChatController : ControllerBase {

        public LineChatController() {}

        [HttpPost]
        public ActionResult POST() {
            string ChannelAccessToken = "LINE的TOKEN";

            try {
                return Ok();
            } catch (Exception ex) {
                return Ok();
            }

        }
    }
}