using System.Collections.Generic;
using System.Web.Http;
using FitnessStats.Models;
using FitnessStats.Services;

namespace FitnessStats.Controllers
{
    public class RunkeeperController : ApiController
    {
        private RunkeeperService _runkeeperService = new RunkeeperService();

        [HttpGet]
        public ApiResponse<List<Run>> GetLatestBuildStepFailure()
        {
            return new ApiResponse<List<Run>>(ApiStatusCode.OK, _runkeeperService.GetRuns());
        }
    }
}
