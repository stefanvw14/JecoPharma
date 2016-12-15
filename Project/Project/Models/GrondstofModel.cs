using System;
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

        // BEGIN door Lucas Rob
        public GrondstofModel()
        {
            grondstof_id = -1;
            naam = "";
        }

        // auteur: Roy Willemse
        // Gemaakt om van gekozen medicijnen de grondstoffen op te halen zodat er vervolgens gekeken kan worden naar allergieen.
        public static List<GrondstofModel> getFromMedicijn(int medicijn_id)
        {
            string query = "SELECT g.grondstof_id, g.naam, gr.hoeveelheid FROM Grondstof g INNER JOIN GrondstofRegel gr on g.grondstof_id = gr.grondstof_id WHERE gr.medicijn_id = @p0";
            object[] parameters = { medicijn_id };
            DataTable dt = DatabaseModel.select(query, parameters);

            List<GrondstofModel> grondstoffen = new List<GrondstofModel>();
            foreach (DataRow row in dt.Rows)
            {
                GrondstofModel grondstof = new GrondstofModel();
                grondstof.Grondstof_id = int.Parse(row["grondstof_id"].ToString());
                grondstof.Naam = row["naam"].ToString();
                grondstoffen.Add(grondstof);
            }
            return grondstoffen;
        }



        // EINDE
    }
}