using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyForm;
using MySql.Data.MySqlClient;

namespace CreateTable
{
    public class Program
    {


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

        public string HStext;
       

        public void MReaderMain()
        {
            FlappyForm.Form1 formlink = new Form1();
            string cs = @"server=localhost;userid=root;password=;database=scores";

            using var con = new MySqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM highscores ORDER BY score DESC LIMIT 10";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2}", rdr.GetString(1), rdr.GetInt32(2),
                    rdr.GetDateTime(3));
                var text = ("{0} {1} {2}", rdr.GetString(1), rdr.GetInt32(2),
                rdr.GetDateTime(3));
               // HStext = text.ToString();
                formlink.HStext = text.ToString();

            }
            
        }
    }
}