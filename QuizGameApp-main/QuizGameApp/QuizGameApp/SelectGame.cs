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
    public partial class SelectGame : Form
    {

        private int userId;
        private string gameName;

        GameCLass game = new GameCLass();
        public SelectGame(int userId, string gameName)
        {
            InitializeComponent();
            this.userId = userId;
            this.gameName = gameName;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            showData();
        }

        private void showData()
        {
            //to show course list on datagridview
            MySqlCommand command = new MySqlCommand("SELECT game.GameID, game.GameName, game.Description, game.CreatedAt, user.UserName AS CreatedBy, game.QuestionCount FROM game JOIN user ON game.CreatedBy = user.UserID and game.QuestionCount > 0");
            dataGridView_gameList.DataSource = game.getGameList(command);
        }

        private void dataGridView_gameList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_gameList.CurrentRow != null)
            {
                textBox_gameNameShow.Text = Convert.ToString(dataGridView_gameList.CurrentRow.Cells["GameName"].Value);
                textBox_gameDescriptionShow.Text = Convert.ToString(dataGridView_gameList.CurrentRow.Cells["Description"].Value);
                textBox_createByShow.Text = Convert.ToString(dataGridView_gameList.CurrentRow.Cells["CreatedBy"].Value);
                textBox_questionCountShow.Text = Convert.ToString(dataGridView_gameList.CurrentRow.Cells["QuestionCount"].Value);
            }

            else
            {
                MessageBox.Show("Please select a game to con tinue!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            
        }
    }
}
