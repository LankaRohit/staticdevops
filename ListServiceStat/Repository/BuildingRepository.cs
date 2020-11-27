using ListServiceStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListServiceStat.Repository
{
    public class BuildingRepository:IBuildingRepository
    {
        private  List<Building> buildings;

        public BuildingRepository()
        {
            buildings = new List<Building>()
            {
                new Building { building_id = 1, description = "1BHK", address = "sdv", cost = 100 },
                  new Building { building_id = 2, description = "2BHK", address = "sdjv", cost = 100 },
                    new Building { building_id = 3, description = "3BHK", address = "djvs", cost = 100 },
                      new Building { building_id = 4, description = "1BHK", address = "jdgv", cost = 100 },
            };

        }
        public IEnumerable<Building> GetAll()
        {
            var buildinglist = buildings.ToList();
            return buildinglist;
        }

        public Building GetById(int building_id)
        {
            return buildings.FirstOrDefault(p => p.building_id == building_id);
        }






    }
}
