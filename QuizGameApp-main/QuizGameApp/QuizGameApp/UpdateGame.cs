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
    public partial class UpdateGame : Form
    {
        private int userID;
        private string userName;
        private int gameId;
        private string gameName;
        private string description;

        GameCLass game = new GameCLass();

        public UpdateGame(int gameId, string gameName, string description)
        {
            InitializeComponent();
            this.gameId = gameId;
            this.gameName = gameName;
            this.description = description;
            showGame();
        }

        public UpdateGame(int userID, string userName)
        {
            this.userID = userID;
            this.userName = userName;
        }

        private void showGame()
        {
            textBox_gameNameUpdate.Text = gameName; 
            textBox_gameDescriptionUpdate.Text = description;
        }

        private void button_update_Click(object sender, EventArgs e)
        {

            game.UpdateGame(gameId, textBox_gameNameUpdate.Text, textBox_gameDescriptionUpdate.Text);
            MessageBox.Show("Edit game succesfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            CreateNewGame createNewGame = new CreateNewGame(userID, userName);
            createNewGame.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewGame createNewGame = new CreateNewGame(userID, userName);
            createNewGame.Show();
        }
    }
}
