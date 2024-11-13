using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGameApp
{
    public partial class QuestionManage : Form
    {
        private int userID; 
        private int gameID;
        private string userName;

        Question question = new Question();

        public QuestionManage(int gameID)
        {
            this.gameID = gameID;
            InitializeComponent();
        }

        public QuestionManage(int userID, int gameID, string userName) : this(userID)
        {
            this.gameID = gameID;
            this.userName = userName;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.label_questionManage.Text = $"Question manage of {question.GetGameName(gameID)}";
            ShowData();

        }

        private void ShowData()
        {
            MySqlCommand command = new MySqlCommand("SELECT question.QuestionID, game.GameName AS GameName, question.QuestionText, question.QuestionType, question.AvailableAnswer, question.CorrectAnswer, question.CreatedAt, question.UpdatedAt FROM question JOIN game ON game.GameID = question.GameID WHERE game.GameID = @gameID");
            command.Parameters.AddWithValue("@gameID", gameID);
            dataGridView_questionList.DataSource = question.GetQuestionList(command);
        }

        //private void QuestionManage_Load(object sender, EventArgs e)
        //{
        //    ShowData();
        //}

        private void button_addQuestion_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateQuestion createQuestion = new CreateQuestion(gameID);
            createQuestion.Show();

        }

        private void button_editQuestion_Click(object sender, EventArgs e)
        {
            if (dataGridView_questionList.CurrentRow != null)
            {

                int questionId = Convert.ToInt32(dataGridView_questionList.CurrentRow.Cells["QuestionID"].Value);
                int gameId = gameID;
                string questionText = dataGridView_questionList.CurrentRow.Cells["QuestionText"].Value.ToString();
                string questionType = dataGridView_questionList.CurrentRow.Cells["QuestionType"].Value.ToString();
                string correctAnswer = dataGridView_questionList.CurrentRow.Cells["CorrectAnswer"].Value.ToString();

                this.Hide();
                UpdateQuestion updateQuestion = new UpdateQuestion(questionId, gameID, questionText, questionType, correctAnswer);
                updateQuestion.Show();

            } 

            else
            {
                MessageBox.Show("Please Select A Question To Edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_deleteQuestion_Click(object sender, EventArgs e)
        {
            if (dataGridView_questionList.CurrentRow != null)
            {
                int questionId = Convert.ToInt32(dataGridView_questionList.CurrentRow.Cells["QuestionID"].Value);
                DialogResult result = MessageBox.Show("Are you sure to delete this question?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    question.DeleteQuestion(questionId);
                } 
                
                else
                {
                    return;
                }

                ShowData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewGame createNewGame = new CreateNewGame(userID, userName);
            createNewGame.Show();
        }

        private void button_saveQuestion_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewGame createNewGame = new CreateNewGame(userID, userName);
            createNewGame.Show();
        }
    }
}
