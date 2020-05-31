using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Service;
using WebApi.Model;
using Newtonsoft.Json;

namespace WebApi.Controllers
{
    // route : /api/post/json-post
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
    
        [HttpPost]
        [Route("json-post")]
        public ActionResult jsonPost([FromBody] JsonRegisterInfo reg_info){
            Response res = PostService.GetResponseData(reg_info);
            return Ok(res);
        }

    }
}
