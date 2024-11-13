using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuizGameApp
{
    class GameCLass
    {
        DBConnect connect = new DBConnect();
        private DateTime createAt = DateTime.Now;

        public bool insertGame(string gameName, string description, DateTime createAt, int userID)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `game`(`GameName`, `Description`, `CreatedAt`, `CreatedBy`) VALUES (@gameName, @description, @createAt, @createdBy)", connect.getConnection);

            command.Parameters.Add("@gameName", MySqlDbType.VarChar).Value = gameName;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
            command.Parameters.Add("@createAt", MySqlDbType.DateTime).Value = createAt;
            command.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = userID;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public void DeleteGame(int gameId)
        {
            connect.openConnect();
            MySqlCommand command = new MySqlCommand("Delete from game where GameID = @gameId",connect.getConnection);
            command.Parameters.AddWithValue("GameID", gameId);
            
            command.ExecuteNonQuery();
            connect.closeConnect();
            return;
        }

        public void UpdateGame(int gameId, string gameName, string description)
        {
            connect.openConnect();
            MySqlCommand command = new MySqlCommand("Update game set GameName = @gameName, Description = @description where GameID = @gameID", connect.getConnection);
            command.Parameters.AddWithValue("gameId", gameId);
            command.Parameters.AddWithValue("gameName", gameName);
            command.Parameters.AddWithValue("Description", description);
            command.ExecuteNonQuery();
            connect.closeConnect();
            return ;
        }

        public void GetGameInfo()
        {
            connect.openConnect();
            MySqlCommand command = new MySqlCommand("Select GameID, GameName from Game", connect.getConnection);

        }

        public void CreateGameSession(int gameId, int userId)
        {
            connect.openConnect();
            MySqlCommand command = new MySqlCommand("Insert into result (GameID, UserID) values (@gameId, @userId)", connect.getConnection);
            command.Parameters.AddWithValue("gameId", gameId);
            command.Parameters.AddWithValue("userId", userId);
            command.ExecuteNonQuery();
            connect.closeConnect();
            return;
        }

        public DataTable getGameList(MySqlCommand command)
        {
            command.Connection = connect.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
