namespace QuizGameApp
{
    partial class SelectGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.label_questionManage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_gameList = new System.Windows.Forms.DataGridView();
            this.textBox_gameDescriptionShow = new System.Windows.Forms.TextBox();
            this.textBox_gameNameShow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_createByShow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_questionCountShow = new System.Windows.Forms.TextBox();
            this.button_play = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gameList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label_questionManage
            // 
            this.label_questionManage.AutoSize = true;
            this.label_questionManage.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label_questionManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.label_questionManage.Location = new System.Drawing.Point(439, 21);
            this.label_questionManage.Name = "label_questionManage";
            this.label_questionManage.Size = new System.Drawing.Size(345, 37);
            this.label_questionManage.TabIndex = 0;
            this.label_questionManage.Text = "Select A Game To Play";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label_questionManage);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 90);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(4, 444);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 25);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView_gameList
            // 
            this.dataGridView_gameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_gameList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_gameList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_gameList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_gameList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_gameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_gameList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_gameList.Location = new System.Drawing.Point(4, 92);
            this.dataGridView_gameList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_gameList.Name = "dataGridView_gameList";
            this.dataGridView_gameList.RowHeadersWidth = 120;
            this.dataGridView_gameList.RowTemplate.Height = 24;
            this.dataGridView_gameList.Size = new System.Drawing.Size(1243, 352);
            this.dataGridView_gameList.TabIndex = 5;
            this.dataGridView_gameList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_gameList_CellMouseClick);
            // 
            // textBox_gameDescriptionShow
            // 
            this.textBox_gameDescriptionShow.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_gameDescriptionShow.Location = new System.Drawing.Point(231, 530);
            this.textBox_gameDescriptionShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_gameDescriptionShow.Multiline = true;
            this.textBox_gameDescriptionShow.Name = "textBox_gameDescriptionShow";
            this.textBox_gameDescriptionShow.Size = new System.Drawing.Size(493, 217);
            this.textBox_gameDescriptionShow.TabIndex = 10;
            // 
            // textBox_gameNameShow
            // 
            this.textBox_gameNameShow.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_gameNameShow.Location = new System.Drawing.Point(231, 473);
            this.textBox_gameNameShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_gameNameShow.Name = "textBox_gameNameShow";
            this.textBox_gameNameShow.Size = new System.Drawing.Size(493, 32);
            this.textBox_gameNameShow.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(76, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(76, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Game Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(761, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Create By";
            // 
            // textBox_createByShow
            // 
            this.textBox_createByShow.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_createByShow.Location = new System.Drawing.Point(883, 476);
            this.textBox_createByShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_createByShow.Name = "textBox_createByShow";
            this.textBox_createByShow.Size = new System.Drawing.Size(240, 32);
            this.textBox_createByShow.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(761, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number Of Questions";
            // 
            // textBox_questionCountShow
            // 
            this.textBox_questionCountShow.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_questionCountShow.Location = new System.Drawing.Point(1001, 523);
            this.textBox_questionCountShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_questionCountShow.Name = "textBox_questionCountShow";
            this.textBox_questionCountShow.Size = new System.Drawing.Size(121, 32);
            this.textBox_questionCountShow.TabIndex = 14;
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_play.Location = new System.Drawing.Point(883, 628);
            this.button_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(163, 52);
            this.button_play.TabIndex = 15;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // SelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1249, 753);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.textBox_questionCountShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_createByShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_gameDescriptionShow);
            this.Controls.Add(this.textBox_gameNameShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_gameList);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectGame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gameList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_questionManage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_gameList;
        private System.Windows.Forms.TextBox textBox_gameDescriptionShow;
        private System.Windows.Forms.TextBox textBox_gameNameShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_createByShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_questionCountShow;
        private System.Windows.Forms.Button button_play;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}