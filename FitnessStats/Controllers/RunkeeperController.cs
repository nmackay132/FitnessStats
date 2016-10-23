using System.Collections.Generic;
using System.Web.Http;
using FitnessStats.Models;
using FitnessStats.Services;

namespace FitnessStats.Controllers
{
    public class RunkeeperController : ApiController
    {
        private RunkeeperService _runkeeperService = new RunkeeperService();
        private DataService _dataService = new DataService();

        [HttpGet]
        public ApiResponse<List<Run>> GetRuns()
        {
            return new ApiResponse<List<Run>>(ApiStatusCode.OK, _dataService.GetRuns());
        }
    }
}
