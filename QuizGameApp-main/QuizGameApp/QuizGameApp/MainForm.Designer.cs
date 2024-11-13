namespace QuizGameApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3_roleshow = new System.Windows.Forms.Label();
            this.label2_usernameshow = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_play = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_viewStudentsList = new System.Windows.Forms.Button();
            this.button_viewStudentsResult = new System.Windows.Forms.Button();
            this.button_createNewGame = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(333, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Greenwich Quiz Game";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label3_roleshow);
            this.panel2.Controls.Add(this.label2_usernameshow);
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 37);
            this.panel2.TabIndex = 2;
            // 
            // label3_roleshow
            // 
            this.label3_roleshow.AutoSize = true;
            this.label3_roleshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.label3_roleshow.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3_roleshow.ForeColor = System.Drawing.Color.White;
            this.label3_roleshow.Location = new System.Drawing.Point(860, 11);
            this.label3_roleshow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3_roleshow.Name = "label3_roleshow";
            this.label3_roleshow.Size = new System.Drawing.Size(53, 17);
            this.label3_roleshow.TabIndex = 1;
            this.label3_roleshow.Text = "Admin";
            // 
            // label2_usernameshow
            // 
            this.label2_usernameshow.AutoSize = true;
            this.label2_usernameshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.label2_usernameshow.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2_usernameshow.ForeColor = System.Drawing.Color.White;
            this.label2_usernameshow.Location = new System.Drawing.Point(700, 11);
            this.label2_usernameshow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2_usernameshow.Name = "label2_usernameshow";
            this.label2_usernameshow.Size = new System.Drawing.Size(130, 17);
            this.label2_usernameshow.TabIndex = 0;
            this.label2_usernameshow.Text = "Nguyen Trong Duc";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_play);
            this.panel3.Controls.Add(this.button_logout);
            this.panel3.Controls.Add(this.button_viewStudentsList);
            this.panel3.Controls.Add(this.button_viewStudentsResult);
            this.panel3.Controls.Add(this.button_createNewGame);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(455, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 448);
            this.panel3.TabIndex = 4;
            // 
            // button_play
            // 
            this.button_play.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.button_play.Location = new System.Drawing.Point(285, 140);
            this.button_play.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(166, 46);
            this.button_play.TabIndex = 6;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.button_logout.Location = new System.Drawing.Point(285, 384);
            this.button_logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(166, 46);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // button_viewStudentsList
            // 
            this.button_viewStudentsList.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button_viewStudentsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.button_viewStudentsList.Location = new System.Drawing.Point(285, 58);
            this.button_viewStudentsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_viewStudentsList.Name = "button_viewStudentsList";
            this.button_viewStudentsList.Size = new System.Drawing.Size(166, 46);
            this.button_viewStudentsList.TabIndex = 4;
            this.button_viewStudentsList.Text = "View Students List";
            this.button_viewStudentsList.UseVisualStyleBackColor = true;
            // 
            // button_viewStudentsResult
            // 
            this.button_viewStudentsResult.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button_viewStudentsResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.button_viewStudentsResult.Location = new System.Drawing.Point(26, 140);
            this.button_viewStudentsResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_viewStudentsResult.Name = "button_viewStudentsResult";
            this.button_viewStudentsResult.Size = new System.Drawing.Size(166, 46);
            this.button_viewStudentsResult.TabIndex = 3;
            this.button_viewStudentsResult.Text = "View Students Result";
            this.button_viewStudentsResult.UseVisualStyleBackColor = true;
            // 
            // button_createNewGame
            // 
            this.button_createNewGame.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button_createNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.button_createNewGame.Location = new System.Drawing.Point(26, 58);
            this.button_createNewGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_createNewGame.Name = "button_createNewGame";
            this.button_createNewGame.Size = new System.Drawing.Size(166, 46);
            this.button_createNewGame.TabIndex = 1;
            this.button_createNewGame.Text = "Manage Game";
            this.button_createNewGame.UseVisualStyleBackColor = true;
            this.button_createNewGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(481, 32);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(215, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Control Panel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QuizGameApp.Properties.Resources._3;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 153);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 460);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuizGameApp.Properties.Resources.university_of_greenwich2357;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(338, -29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 156);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3_roleshow;
        private System.Windows.Forms.Label label2_usernameshow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_viewStudentsList;
        private System.Windows.Forms.Button button_viewStudentsResult;
        private System.Windows.Forms.Button button_createNewGame;
        private System.Windows.Forms.Button button_play;
    }
}