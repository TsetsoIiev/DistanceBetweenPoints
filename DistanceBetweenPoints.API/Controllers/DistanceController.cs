using DistanceBetweenPoints.Services.Interfaces;
using DistanceBetweenPoints.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace DistanceBetweenPoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DistanceController : ControllerBase
    {
        private readonly IDistanceService _distanceService;

        public DistanceController(IDistanceService distanceService)
        {
            _distanceService = distanceService;
        }

        [HttpPost("[action]")]
        public IActionResult CalculateDistance(DistanceInputModel model)
        {
            var result = _distanceService.CalculateDistance(model);

            return Ok(result);
        }
    }
}
