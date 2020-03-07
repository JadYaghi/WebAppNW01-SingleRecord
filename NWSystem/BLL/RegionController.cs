using NWSystem.DAL;
using NWSystem.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWSystem.BLL
{
    public class RegionController
    {
        public List<Region> Regions_List()
        {
            using (var context = new NWContext())
            {
                return context.Regions.ToList();
            }
        }
        public Region Regions_FindByID(int regionid)
        {
            using (var context = new NWContext())
            {
                return context.Regions.Find(regionid);
            }
        }
    }
}
