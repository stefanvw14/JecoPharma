﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class GrondstofModel
    {
        //Attributen van Grondstof
        private int grondstof_id;
        private string naam;

        //Property van grondstofnummer en naam
        public int Grondstof_id
        {
            set { grondstof_id = value; }
            get { return grondstof_id; }
        }

        public string Naam
        {
            set { naam = value; }
            get { return naam; }
        }


        public static List<GrondstofModel> getAll()
        {
            string query = "SELECT * FROM Grondstof";
            object[] parameters = { };
            DataTable dt = DatabaseModel.select(query, parameters);

            List<GrondstofModel> grondstoffen = new List<GrondstofModel>();
            foreach (DataRow row in dt.Rows)
            {
                GrondstofModel grondstof = new GrondstofModel();
                grondstof.Grondstof_id = int.Parse(row["grondstof_id"].ToString());
                grondstof.Naam = row["naam"].ToString();
                grondstoffen.Add(grondstof);
            }
            return grondstoffen; //commit
        }

    }
}