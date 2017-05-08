using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Module.Core.Models;

namespace Module.Core.Controllers
{
    public class LocationController : Controller
    {
        private readonly IRepository<District> districtRepository;

        public LocationController(IRepository<District> districtRepository)
        {
            this.districtRepository = districtRepository;
        }

        [Route("location/getdistricts/{stateOrProvinceId}")]
        public IActionResult GetDistricts(long stateOrProvinceId)
        {
            var districts = districtRepository
                .Query()
                .Where(x => x.StateOrProvinceId == stateOrProvinceId)
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();

            return Json(districts);
        }
    }
}
