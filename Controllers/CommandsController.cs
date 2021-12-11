using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandApi.Controllers{
    [Route("api/commands")]
    [ApiController]
    public class CommandsApi : ControllerBase{
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(){
            return new string[] {"my", "life", "is", "sweet"};
        }
    }
}