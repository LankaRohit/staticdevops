using ListServiceStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListServiceStat.Repository
{
    public interface IBuildingRepository
    {
        IEnumerable<Building> GetAll();
        Building GetById(int building_id);
    }
}
