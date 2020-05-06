using System.IO;
using LineDeployBot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LineDeployBot.Controllers {
    [ApiController]
    [Route("deploy")]
    public class LineChatController : ControllerBase {
        private readonly string _channelToken;
        public LineChatController(IOptions<AppSettings> appSettings) {
            _channelToken = appSettings.Value.Secrets.ChannelToken;
        }

        [HttpGet]
        public ActionResult<dynamic> Test() {
            return new { status = "ok" };
        }

        [HttpPost]
        public ActionResult<dynamic> Deploy() {
            using(StreamReader stream = new StreamReader(HttpContext.Request.Body)) {
                string body = stream.ReadToEnd();
                var receivedMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(body);
                string message = "你說了:" + receivedMessage.events[0].message.text;
                isRock.LineBot.Utility.ReplyMessage(receivedMessage.events[0].replyToken, message, _channelToken);
            }
            return new { status = "ok" };
        }
    }
}