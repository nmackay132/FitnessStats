using System.Collections.Generic;
using System.Web.Http;
using WebUI.Models;
using WebUI.Services;

namespace WebUI.Controllers
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
