using ACTV.Core.IServices;
using ACTV.Core.Model;
using ACTV.Core.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ACTV.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class BangumiController : Controller
    {
        private readonly IBangumiServices bangumiServices;
        private readonly ILogger<BangumiController> logger;

        public BangumiController(IBangumiServices bangumiServices, ILogger<BangumiController> logger)
        {
            this.bangumiServices = bangumiServices;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{Id}")]
        public async Task<MessageModel<BangumiViewModels>> GetBangumiDetails(int Id)
        {
            var bangumiDetails = await bangumiServices.GetBangumiDetails(Id);

            return new MessageModel<BangumiViewModels>()
            {
                msg = "获取成功",
                response = bangumiDetails,
                success = true
            };
        }
    }
}
