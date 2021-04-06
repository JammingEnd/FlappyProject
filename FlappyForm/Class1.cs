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
        public int score = FlappyForm.Form1.scoreSend;
        private static int scoreSQL;
        public string name;
        private static string nameSend;
        public Program()
        {
            scoreSQL = score;
            nameSend = name;
        }
      

      
        public void Activatesql()
        {

            SQLConnect();
        }
        public void SQLConnect()
        {
            string nameMan = "broederjan";


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
    }
}