using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace alphavotingsystem
{
    class functionCandidate
    {
        dbConnection db = new dbConnection();
        public bool deleteCandidate(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `candidates` WHERE `id` = @id", db.GetConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool insertCandidate(string name, string position, int votes)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `candidates`(`name`, `position`, `votes`) VALUE (@name, @position, @votes)", db.GetConnection);

            command.Parameters.Add("@name", MySqlDbType.Text).Value = name;
            command.Parameters.Add("@position", MySqlDbType.Text).Value = position;
            command.Parameters.Add("@votes", MySqlDbType.Int32).Value = votes;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable getCandidate(MySqlCommand command)
        {
            command.Connection = db.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
