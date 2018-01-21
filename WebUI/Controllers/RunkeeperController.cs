using System.Collections.Generic;
using System.Web.Http;
using FitnessStats.Models;
using FitnessStats.Services;

namespace WebUI.Controllers
{
    public class RunkeeperController : ApiController
    {
        private readonly IRunkeeperService _runkeeperService;

        public RunkeeperController(IRunkeeperService runkeeperService)
        {
            _runkeeperService = runkeeperService;
        }

        [HttpGet]
        public ApiResponse<IList<Run>> GetRuns()
        {
            return new ApiResponse<IList<Run>>(ApiStatusCode.OK, _runkeeperService.GetRuns());
        }
    }
}
