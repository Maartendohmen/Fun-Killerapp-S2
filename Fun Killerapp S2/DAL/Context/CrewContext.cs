using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Context
{
    class CrewContext : Connectionstring, ICrew
    {
        public List<object> GetAll()
        {
            List<Crew> Crewmembers = new List<Crew>();
            conn.Open();
            string getallcrewmembers = "SELECT CrewID, CrewIDBoss, Name, Lasstimelogin FROM Crew";
            SqlCommand GetAllCrewmembers = new SqlCommand(getallcrewmembers, conn);

            using (SqlDataReader reader = GetAllCrewmembers.ExecuteReader())
            {
                while (reader.Read())
                {
                    Crewmembers.Add(new Crew(Convert.ToInt32(reader["CrewID"].ToString()), Convert.ToInt32(reader["CrewIDBoss"].ToString()), reader["Name"].ToString(), DateTime.Parse(reader["Lasttimelogin"].ToString())));
                }
            }
            conn.Close();
            return Crewmembers.Cast<object>().ToList();
        }

        public object GetOne(int Crewid)
        {
            conn.Open();
            string getCrewmember = "SELECT CrewID, CrewIDBoss, Name, Lasttimelogin FROM Crew WHERE CrewID = @id";
            SqlCommand GetCrewmember = new SqlCommand(getCrewmember, conn);
            GetCrewmember.Parameters.AddWithValue("id", Crewid);

            using (SqlDataReader reader = GetCrewmember.ExecuteReader())
            {
                while (reader.Read())
                {
                    Crew toadd = new Crew(Convert.ToInt32(reader["CrewID"].ToString()), Convert.ToInt32(reader["CrewIDBoss"].ToString()), reader["Name"].ToString(), DateTime.Parse(reader["Lasttimelogin"].ToString()));
                    conn.Close();
                    return toadd;
                }
            }
            return null;
        }

        public void Save(DateTime lasttimelogin, int crewid)
        {
            string updatequery = @"UPDATE Crew SET Lasttimelogin = @lasttimelogin WHERE CrewID = @id;";
            SqlCommand UpdateLasttimelogin = new SqlCommand(updatequery, conn);
            UpdateLasttimelogin.Parameters.AddWithValue("lasttimelogin", lasttimelogin);
            UpdateLasttimelogin.Parameters.AddWithValue("id", crewid);
            conn.Open();
            UpdateLasttimelogin.ExecuteNonQuery();
            conn.Close();            
        }
    
    }
}
