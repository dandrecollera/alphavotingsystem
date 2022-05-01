using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace alphavotingsystem
{
    class functionVotes
    {
        dbConnection db = new dbConnection();
        public DataTable getPositions(string position)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `candidates` WHERE `position` LIKE @position", db.GetConnection);
            command.Parameters.AddWithValue("@position", position);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public void updateVotes(int[] id, int[] votes)
        {
            for (int x = 0; x < 7; x++)
            {
                int finalVote = votes[x] + 1;
                MySqlCommand command = new MySqlCommand("UPDATE `candidates` SET `votes` = @votes WHERE `candidates`.`id` = @id", db.GetConnection);
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id[x];
                command.Parameters.Add("votes", MySqlDbType.Int32).Value = finalVote;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
        }

        public void addHistory()
        {
            functionSettings student = new functionSettings();
            MySqlCommand command = new MySqlCommand("INSERT INTO `voters`(`student_id`, `name`, `year`, `section`, `strand`) VALUE (@student_id, @name, @year, @section, @strand)", db.GetConnection);

            command.Parameters.Add("@student_id", MySqlDbType.VarChar).Value = student.id();
            command.Parameters.Add("@name", MySqlDbType.Text).Value = student.name();
            command.Parameters.Add("@year", MySqlDbType.Text).Value = student.year();
            command.Parameters.Add("@section", MySqlDbType.Text).Value = student.section();
            command.Parameters.Add("@strand", MySqlDbType.Text).Value = student.strand();

            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
        }
    }
}
