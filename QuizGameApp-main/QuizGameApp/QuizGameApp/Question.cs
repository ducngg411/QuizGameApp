using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameApp
{
    class Question
    {

        public static string QuestionTypeMultipleChoice = "Multiple choice question";
        public static string QuestionTypeTrueFalse = "True false question";
        public static string QuestionTypeOpenEnded = "Open-ended question";

        DBConnect connect = new DBConnect();

        public string GetGameName(int gameId)
        {
            connect.openConnect();
            MySqlCommand command = new MySqlCommand("Select GameName from game where GameID = @gameId", connect.getConnection);
            command.Parameters.AddWithValue("@gameId", gameId);
            var result = command.ExecuteScalar();
            var gameName = Convert.ToString(result);
            connect.closeConnect();   
            return gameName;
        }
           
        
        public void CreateQuestion(int gameId, string questionText, string questionType, string availableAnswer, string correctAnswer)
        {
            connect.openConnect();
            MySqlCommand command = new MySqlCommand("Insert into question (GameID, QuestionText, QuestionType, AvailableAnswer, CorrectAnswer) value (@gameId, @questionText, @questionType, @availableAnswer, @correctAnswer)", connect.getConnection);
            command.Parameters.AddWithValue("@gameId", gameId);
            command.Parameters.AddWithValue("@questionText", questionText);
            command.Parameters.AddWithValue("@questionType", questionType);
            command.Parameters.AddWithValue("@availableAnswer", availableAnswer);
            command.Parameters.AddWithValue("@correctAnswer", correctAnswer);

            command.ExecuteNonQuery();
            connect.closeConnect();
            return;
        }

        public void UpdateQuestion(int questionId, int gameId,  string questionText, string questionType, string CorrectAnswer)
        {
            connect.openConnect();
            MySqlCommand command = new MySqlCommand("UPDATE question SET GameID = @gameId, QuestionText = @questionText, QuestionType = @questionType, CorrectAnswer = @CorrectAnswer WHERE QuestionID = @questionId", connect.getConnection);

            command.Parameters.AddWithValue("@questionId", questionId);
            command.Parameters.AddWithValue("@gameId", gameId);
            command.Parameters.AddWithValue("@questionText", questionText);
            command.Parameters.AddWithValue("@questionType", questionType);
            command.Parameters.AddWithValue("@CorrectAnswer", CorrectAnswer);

            command.ExecuteNonQuery();
            connect.closeConnect();
        }

        public void DeleteQuestion(int questionId)
        {
            connect.openConnect();
            MySqlCommand command = new MySqlCommand("Delete from question Where QuestionID = @questionId",connect.getConnection);
            command.Parameters.AddWithValue("questionId", questionId);

            command.ExecuteNonQuery();
            connect.closeConnect();
        }

        public DataTable GetQuestionList(MySqlCommand command)
        {
            command.Connection = connect.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
