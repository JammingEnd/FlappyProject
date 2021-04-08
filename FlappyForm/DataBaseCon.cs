using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyForm;
using MySql.Data.MySqlClient;

namespace CreateTable
{
    public class Program
    {

        /// <summary>
        /// Sends score and name to the sql database
        /// </summary>
        public void SQLConnect(string nameSend, int scoreSQL)
        {



            string cs = @"server=localhost;userid=root;password=;database=scores";

            using var con = new MySqlConnection(cs);
            con.Open();

            var sql = "INSERT INTO highscores(name, score) VALUES(@name, @score)";
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@name", nameSend);
            cmd.Parameters.AddWithValue("@score", scoreSQL);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Console.WriteLine("row inserted");
        }

         public DataTable dtscore = new DataTable(); //creates a new datatable 
        
        /// <summary>
        /// connects to the sql database, queries the top 10 and puts it in the datatable
        /// </summary>
        /// <returns></returns>
        public DataTable MReaderMain()
        {

            dtscore.Columns.Add("Name-score-time");
            string cs = @"server=localhost;userid=root;password=;database=scores";

            using var con = new MySqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM highscores ORDER BY score DESC LIMIT 10";
            using (var cmd = new MySqlCommand(sql, con))
            {
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var text = ("Name: " +rdr.GetString(1),"Score: " + rdr.GetInt32(2),
                           "Time: " + rdr.GetDateTime(3));
                        // HStext = text.ToString();
                        
                        dtscore.Rows.Add(text.ToString());

                    }

                }
            }

            return dtscore;



        }
    }
}