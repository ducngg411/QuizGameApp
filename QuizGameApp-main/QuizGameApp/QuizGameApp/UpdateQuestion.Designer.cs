namespace QuizGameApp
{
    partial class UpdateQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateQuestion));
            this.textBox_questionTextUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_questionTypeUpdate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_correctAnswerUpdate = new System.Windows.Forms.TextBox();
            this.checkedListBox_correctAnswer = new System.Windows.Forms.CheckedListBox();
            this.button_addCorrectAnswer = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.listView_correctAnswerUpdate = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_questionTextUpdate
            // 
            this.textBox_questionTextUpdate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_questionTextUpdate.Location = new System.Drawing.Point(85, 178);
            this.textBox_questionTextUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_questionTextUpdate.Multiline = true;
            this.textBox_questionTextUpdate.Name = "textBox_questionTextUpdate";
            this.textBox_questionTextUpdate.Size = new System.Drawing.Size(392, 115);
            this.textBox_questionTextUpdate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(80, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question text";
            // 
            // comboBox_questionTypeUpdate
            // 
            this.comboBox_questionTypeUpdate.DisplayMember = "Multiple choice question";
            this.comboBox_questionTypeUpdate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBox_questionTypeUpdate.FormattingEnabled = true;
            this.comboBox_questionTypeUpdate.Items.AddRange(new object[] {
            "Multiple choice question",
            "True or false question",
            "Open-ended question"});
            this.comboBox_questionTypeUpdate.Location = new System.Drawing.Point(85, 104);
            this.comboBox_questionTypeUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_questionTypeUpdate.Name = "comboBox_questionTypeUpdate";
            this.comboBox_questionTypeUpdate.Size = new System.Drawing.Size(392, 29);
            this.comboBox_questionTypeUpdate.TabIndex = 2;
            this.comboBox_questionTypeUpdate.ValueMember = "Multiple choice question";
            this.comboBox_questionTypeUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBox_questionTypeUpdate_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(80, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Question type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(80, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Correct answer";
            // 
            // textBox_correctAnswerUpdate
            // 
            this.textBox_correctAnswerUpdate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_correctAnswerUpdate.Location = new System.Drawing.Point(85, 324);
            this.textBox_correctAnswerUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_correctAnswerUpdate.Multiline = true;
            this.textBox_correctAnswerUpdate.Name = "textBox_correctAnswerUpdate";
            this.textBox_correctAnswerUpdate.Size = new System.Drawing.Size(392, 43);
            this.textBox_correctAnswerUpdate.TabIndex = 4;
            // 
            // checkedListBox_correctAnswer
            // 
            this.checkedListBox_correctAnswer.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.checkedListBox_correctAnswer.FormattingEnabled = true;
            this.checkedListBox_correctAnswer.Location = new System.Drawing.Point(85, 372);
            this.checkedListBox_correctAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_correctAnswer.Name = "checkedListBox_correctAnswer";
            this.checkedListBox_correctAnswer.Size = new System.Drawing.Size(392, 129);
            this.checkedListBox_correctAnswer.TabIndex = 6;
            // 
            // button_addCorrectAnswer
            // 
            this.button_addCorrectAnswer.BackColor = System.Drawing.Color.LimeGreen;
            this.button_addCorrectAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addCorrectAnswer.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_addCorrectAnswer.Location = new System.Drawing.Point(481, 324);
            this.button_addCorrectAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.button_addCorrectAnswer.Name = "button_addCorrectAnswer";
            this.button_addCorrectAnswer.Size = new System.Drawing.Size(44, 42);
            this.button_addCorrectAnswer.TabIndex = 8;
            this.button_addCorrectAnswer.Text = "+";
            this.button_addCorrectAnswer.UseVisualStyleBackColor = false;
            this.button_addCorrectAnswer.Click += new System.EventHandler(this.button_addCorrectAnswer_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button_update.Location = new System.Drawing.Point(199, 506);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(181, 54);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // listView_correctAnswerUpdate
            // 
            this.listView_correctAnswerUpdate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.listView_correctAnswerUpdate.HideSelection = false;
            this.listView_correctAnswerUpdate.Location = new System.Drawing.Point(85, 372);
            this.listView_correctAnswerUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.listView_correctAnswerUpdate.Name = "listView_correctAnswerUpdate";
            this.listView_correctAnswerUpdate.Size = new System.Drawing.Size(392, 130);
            this.listView_correctAnswerUpdate.TabIndex = 10;
            this.listView_correctAnswerUpdate.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(158, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "UPDATE QUESTION FORM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView_correctAnswerUpdate);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_addCorrectAnswer);
            this.Controls.Add(this.checkedListBox_correctAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_correctAnswerUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_questionTypeUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_questionTextUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_questionTextUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_questionTypeUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_correctAnswerUpdate;
        private System.Windows.Forms.CheckedListBox checkedListBox_correctAnswer;
        private System.Windows.Forms.Button button_addCorrectAnswer;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ListView listView_correctAnswerUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}