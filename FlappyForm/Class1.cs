using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CreateTable
{
    class Program
    {
        public int score = FlappyForm.Form1.scoreSend;
        private static int scoreSQL;

        void Awake()
        {
            scoreSQL = score;
        }
        static void Main(string[] args)
        {
            string nameMan = "broederjan";


            string cs = @"server=%;userid=Jammie;password=5687;database=scores";

            using var con = new MySqlConnection(cs);
            con.Open();

            var sql = "INSERT INTO highscores(name, score) VALUES(@name, @score)";
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@name", nameMan);
            cmd.Parameters.AddWithValue("@score", scoreSQL);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Console.WriteLine("row inserted");
        }
    }
}