using DistanceBetweenPoints.Services.Interfaces;
using DistanceBetweenPoints.Services.Models;

namespace DistanceBetweenPoints.Tests
{
    public class DistanceObj
    {
        private readonly IDistanceService _distanceService;
        private readonly DistanceInputModel _model;

        public DistanceObj(IDistanceService distanceService, DistanceInputModel model)
        {
            _distanceService = distanceService;
            _model = model;
        }

        public double CalculateDistance()
        {
            return _distanceService.CalculateDistance(_model);
        }
    }
}
