using System.Web.Http;
using FitnessStats.Models;
using FitnessStats.Services;

namespace WebUI.Controllers
{
    public class StatsSummaryController : ApiController
    {
        private readonly IRunkeeperService _runkeeperService;

        public StatsSummaryController(IRunkeeperService runkeeperService)
        {
            _runkeeperService = runkeeperService;
        }

        [HttpGet]
        public ApiResponse<StatsSummaryReadModel> Get()
        {
            return new ApiResponse<StatsSummaryReadModel>(ApiStatusCode.OK, _runkeeperService.GetStatsSummary());
        }
    }
}