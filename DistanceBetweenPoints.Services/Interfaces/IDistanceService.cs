using DistanceBetweenPoints.Services.Models;

namespace DistanceBetweenPoints.Services.Interfaces
{
    public interface IDistanceService
    {
        public double CalculateDistance(DistanceInputModel model);
    }
}
