using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuizGameApp
{
    public partial class MainForm : Form
    {
        private string userName;
        private int userID;

        public MainForm(string userName, int userID)
        {
            InitializeComponent();
            this.userName = userName;
            this.userID = userID;
            label2_usernameshow.Text = $"Hi! {userName}";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewGame createNewGame = new CreateNewGame(userID, userName);
            createNewGame.Show();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectGame selectGame = new SelectGame(userID, userName);
            selectGame.Show();
        }
    }
}
