using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Project.Models
{
    public class ConflictModel
    {
        //Attributen van Grondstof
        private int conflict_id;
        private int grondstof_id1;
        private int grondstof_id2;


        //Property van grondstofnummer en naam
        public int Grondstof_id1
        {
            set { grondstof_id1 = value; }
            get { return grondstof_id1; }
        }

        public int Grondstof_id2
        {
            set { grondstof_id2 = value; }
            get { return grondstof_id2; }
        }

        public int Conflict_id
        {
            set { conflict_id = value; }
            get { return conflict_id; }
        }


        public static List<ConflictModel> getAll()
        {
            string query = "SELECT * FROM Conflict";
            object[] parameters = { };
            DataTable dt = DatabaseModel.select(query, parameters); //TBD

            List<ConflictModel> conflicten = new List<ConflictModel>();
            foreach (DataRow row in dt.Rows)
            {
                ConflictModel conflict = new ConflictModel();
                conflict.Conflict_id = int.Parse(row["conflict_id"].ToString());
                conflict.grondstof_id1 = int.Parse(row["grondstof_id1"].ToString());
                conflict.grondstof_id2 = int.Parse(row["grondstof_id2"].ToString());
                conflicten.Add(conflict);
            }
            return conflicten;
        }
    }
}