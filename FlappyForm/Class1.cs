using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CreateTable
{
    public class Program
    {


        public void SQLConnect(string nameSend, int scoreSQL)
        {



            string cs = @"server=%;userid=Jammie;password=5687;database=scores";

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

        public string name = null;
        public int score = 0;
        public DateTime date;

        public void MReaderMain()
        {
            string cs = @"server=%;userid=Jammie;password=5687;database=scores";

            using var con = new MySqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM highscores ORDER BY score ASC";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2}", rdr.GetString(0), rdr.GetInt32(1),
                    rdr.GetDateTime(2));
                name = rdr.GetString(0);
                score = rdr.GetInt32(1);
                date = rdr.GetDateTime(2);
            }
        }
    }
}