using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.Object
{
    public class Crew
    {
        private int crewid;
        private int crewidboss;
        private string name;
        private DateTime lasttimelogin;

        public int CrewID
        {
            get { return crewid; }
            private set { crewid = value; }
        }

        public int CrewIDBoss
        {
            get { return crewidboss; }
            private set { crewidboss = value; }
        }

        public string Name
        {
            get { return name; }
            private set {   name = value; }
        }

        public DateTime LasttimeLogin
        {
            get { return lasttimelogin; }
            private set { lasttimelogin = value; }
        }

        public Crew(int crewid, int crewidboss, string name, DateTime lasttimelogin)
        {
            this.crewid = crewid;
            this.crewidboss = crewidboss;
            this.name = name;
            this.LasttimeLogin = lasttimelogin;
        }
    }
}
