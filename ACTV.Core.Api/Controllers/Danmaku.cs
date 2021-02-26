using ACTV.Core.Common.Extensions;
using ACTV.Core.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ACTV.Core.Api.Controllers
{
    [Route("api/[controller]/v3")]
    [ApiController]
    public class Danmaku : ControllerBase
    {
        // GET: api/<Dammaku>
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            List<DanmakuViewModels> list = new List<DanmakuViewModels>();
            DanmakuViewModels danmaku = new DanmakuViewModels
            {
                id = "DDDDOAISJDOIFJ1231",
                time = 5,
                text = "明天吃什么",
                mode = 0,
                size = 25,
                author = "DIYGOD",
                color = 16777215
            };

            list.Add(danmaku);

            var data2DArray = list.To2DArray(danmaku => danmaku.time, danmaku => danmaku.mode, danmaku => danmaku.color, danmaku => danmaku.id, danmaku => danmaku.text);
            
            object res = new
            {
                code = 0,
                data = data2DArray
            };
            JsonResult lai = new JsonResult(res);
            return lai;
        }

        // GET api/<Dammaku>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Dammaku>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string text)
        {
            return Ok();
        }

        // PUT api/<Dammaku>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Dammaku>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
