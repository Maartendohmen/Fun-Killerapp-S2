using Fun_Killerapp_S2.DAL.Context;
using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Logic
{
    class CrewRepository
    {
        private ICrew context;

        public CrewRepository()
        {
            this.context = new CrewContext();
        }

        public List<Crew> GetAllCrew()
        {
            return this.context.GetAll().Cast<Crew>().ToList();
        }

        public Crew GetOneCrew(int id)
        {
            return (Crew)this.context.GetOne(id);
        }

        public void SaveLastlogin(DateTime lasttimelogin, int crewid)
        {
            context.Save(lasttimelogin, crewid);
        }
    }
}
