using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyWebApplication.Models;
using MyWebApplication.Services;

namespace MyWebApplication.Controllers
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
