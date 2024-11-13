using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuizGameApp
{
    public partial class CreateNewGame : Form
    {
        private int userID;
        private string userName;

        GameCLass game = new GameCLass();
        public CreateNewGame(int userID, string userName)
        {
            InitializeComponent();
            this.userID = userID;
            this.userName = userName;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            showData();

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_gameName.Text == "" && textBox_gameDescription.Text == "")
            {
                MessageBox.Show("Need fill the name and description to create new game!", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                string gameName = textBox_gameName.Text;
                string description = textBox_gameDescription.Text;
                DateTime dateTime = DateTime.Now;


                if (game.insertGame(gameName, description, dateTime, userID))
                {
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("New game inserted", "Add Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Game not insert", "Add Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showData()
        {
            //to show course list on datagridview
            MySqlCommand command = new MySqlCommand("SELECT game.GameID, game.GameName, game.Description, game.CreatedAt, user.UserName AS CreatedBy, game.QuestionCount FROM game JOIN user ON game.CreatedBy = user.UserID");
            dataGridView_showGameList.DataSource = game.getGameList(command);   
        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_gameName.Clear();
            textBox_gameDescription.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = dataGridView_showGameList.Rows[e.RowIndex].Cells["GameID"].Value;

            if (value != DBNull.Value)
            {
                int gameID = Convert.ToInt32(value);
                QuestionManage questionManage = new QuestionManage(gameID);
                this.Hide();
                questionManage.Show();
            }

            else
            {
                MessageBox.Show("You select a blank row, select the games that contain data to see detailed information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(userName, userID);
            mainForm.Show();
        }


        private void button_deleteGame_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView_showGameList.CurrentRow != null)
                {
                    int questionId = Convert.ToInt32(dataGridView_showGameList.CurrentRow.Cells["GameID"].Value);
                    DialogResult result = MessageBox.Show("Are you sure to delete this game?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        game.DeleteGame(questionId);
                    }

                    else
                    {
                        return;
                    }

                    showData();
                }
            }
        }

        private void button_editGame_Click(object sender, EventArgs e)
        {
            if (dataGridView_showGameList.CurrentRow != null)
            {
                var gameId = Convert.ToInt32(dataGridView_showGameList.CurrentRow.Cells["GameID"].Value);
                var gameName = Convert.ToString(dataGridView_showGameList.CurrentRow.Cells["GameName"].Value);
                var description = Convert.ToString(dataGridView_showGameList.CurrentRow.Cells["Description"].Value);
                this.Hide();
                UpdateGame updateGame = new UpdateGame(gameId, gameName, description);
                updateGame.Show();
            }

            else
            {
                MessageBox.Show("You must select a game first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
