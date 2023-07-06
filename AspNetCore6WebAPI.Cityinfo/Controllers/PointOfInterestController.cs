using AspNetCore6WebAPI.Cityinfo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore6WebAPI.Cityinfo.Controllers
{
    [Route("api/cities/{cityId}/pointofinterest")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointsOfInterst(int cityId)
        {
            // find city
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }
            return Ok(city.pointOfInterest);
        }

        [HttpGet("{pointofinterestid}")]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointOfInterst(int cityId , int pointofinterestid)
        {
            // find city
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }


            // find city
            var pointsOfInterest = city.pointOfInterest.FirstOrDefault(c => c.Id == pointofinterestid);

            if (pointsOfInterest == null)
            {
                return NotFound();
            }
            return Ok(pointsOfInterest);
        }
    }
}
