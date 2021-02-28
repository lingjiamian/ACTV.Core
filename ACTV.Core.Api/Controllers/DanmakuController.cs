using ACTV.Core.Common.Extensions;
using ACTV.Core.IServices;
using ACTV.Core.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ACTV.Core.Api.Controllers
{
    [Route("api/[controller]/v3")]
    [ApiController]
    public class DanmakuController : Controller
    {
        private readonly IDanmakuServices iDanmakuService;
        private readonly ILogger<DanmakuController> iLogger;
        public DanmakuController(IDanmakuServices iDanmakuService, ILogger<DanmakuController> iLogger)
        {
            this.iDanmakuService = iDanmakuService;
            this.iLogger = iLogger;
        }


        // GET: api/<Dammaku>
        [HttpGet]
        public async Task<JsonResult> Get(int Id, int Max)
        {
            //Max是获取的弹幕数量

            var danmakuViewModelsList = (await iDanmakuService.QueryByBangumiIdToList(Id)).Take(Max).ToList();
            
            List<DanmakuViewModels> list = new List<DanmakuViewModels>();
         
            var data2DArray = danmakuViewModelsList.To2DArray(danmaku => danmaku.time, danmaku => danmaku.type, danmaku => danmaku.color, danmaku => danmaku.uid, danmaku => danmaku.text);
            
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
