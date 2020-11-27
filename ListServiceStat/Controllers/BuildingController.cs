using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListServiceStat.Models;
using ListServiceStat.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListServiceStat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingRepository _buildingRepository;
        public BuildingController(IBuildingRepository buildingRepository)
        {
            _buildingRepository = buildingRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                

                IEnumerable<Building> buildinglist = _buildingRepository.GetAll();
            
                return Ok(buildinglist);
            }
            catch
            {
             
                return new NoContentResult();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
             
                var buildinglist = _buildingRepository.GetById(id);
             
                return new OkObjectResult(buildinglist);
            }
            catch
            {
              
                return new NoContentResult();
            }
        }

    }
}
