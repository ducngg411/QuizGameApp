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
    public partial class LoginForm : Form
    {
        UserClass UserClass = new UserClass();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            if (textBox_email.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("You must enter yours email and password!", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string email = textBox_email.Text;
                string password = textBox_password.Text;

                DataTable table = UserClass.getUserList(new MySqlCommand("SELECT * FROM `user` WHERE `EmailAddress`= '" + email + "' AND `Password`='" + password + "'"));
                //DataTable getUsername = UserClass.getUserList(new MySqlCommand("SELECT UserName FROM `user` "))

                if (table.Rows.Count > 0)
                {

                    int role = Convert.ToInt32(table.Rows[0]["Role"]);
                    string userName = Convert.ToString(table.Rows[0]["UserName"]);
                    int userID = Convert.ToInt32(table.Rows[0]["UserID"]);

                    if (role == 0) 
                    {
                        StudentMainForm studentMainForm = new StudentMainForm();
                        this.Hide();
                        studentMainForm.Show();

                    }

                    else if (role == 1)
                    {
                        MainForm main = new MainForm(userName, userID);
                        this.Hide();
                        main.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Your username and password are not exists", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
