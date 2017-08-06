using System.Collections.Generic;
using System.Web.Http;
using FitnessStats.Models;
using FitnessStats.Services;

namespace WebUI.Controllers
{
    public class RunkeeperController : ApiController
    {
        //private RunkeeperService _runkeeperService = new RunkeeperService();
        //private IDataService _dataService = new DataService();
        private IDataService _dataService;

        public RunkeeperController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public ApiResponse<List<Run>> GetRuns()
        {
            return new ApiResponse<List<Run>>(ApiStatusCode.OK, _dataService.GetRuns());
        }
    }
}
