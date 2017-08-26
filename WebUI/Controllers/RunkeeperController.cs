using System.Collections.Generic;
using System.Web.Http;
using FitnessStats.Models;
using FitnessStats.Services;

namespace WebUI.Controllers
{
    public class RunkeeperController : ApiController
    {
        private readonly IDataService _dataService;

        public RunkeeperController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public ApiResponse<IList<Run>> GetRuns()
        {
            return new ApiResponse<IList<Run>>(ApiStatusCode.OK, _dataService.GetRuns());
        }
    }
}
