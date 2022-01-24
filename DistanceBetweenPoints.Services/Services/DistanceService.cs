using DistanceBetweenPoints.Services.Interfaces;
using DistanceBetweenPoints.Services.Models;

namespace DistanceBetweenPoints.Services.Services
{
    public class DistanceService : IDistanceService
    {
        //using harvesine formula
        public double CalculateDistance(DistanceInputModel model)
        {
            double dLat = (Math.PI / 180) * (model.Lat2 - model.Lat1);
            double dLon = (Math.PI / 180) * (model.Long2 - model.Long1);

            // convert to radians
            double lat1 = (Math.PI / 180) * (model.Lat1);
            double lat2 = (Math.PI / 180) * (model.Lat2);

            // apply formulae
            double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                       Math.Pow(Math.Sin(dLon / 2), 2) *
                       Math.Cos(lat1) * Math.Cos(lat2);

            double c = 2 * Math.Asin(Math.Sqrt(a));

            return Constants.EarthRadius * c;
        }
    }
}
