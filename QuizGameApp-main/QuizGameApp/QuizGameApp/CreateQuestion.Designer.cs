namespace QuizGameApp
{
    partial class CreateQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuestion));
            this.textBox_questionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_questionType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_correctAnswer = new System.Windows.Forms.TextBox();
            this.checkedListBox_correctAnswer = new System.Windows.Forms.CheckedListBox();
            this.button_addCorrectAnswer = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.listView_correctAnswer = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_questionText
            // 
            this.textBox_questionText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_questionText.Location = new System.Drawing.Point(113, 219);
            this.textBox_questionText.Multiline = true;
            this.textBox_questionText.Name = "textBox_questionText";
            this.textBox_questionText.Size = new System.Drawing.Size(522, 141);
            this.textBox_questionText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(107, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question text";
            // 
            // comboBox_questionType
            // 
            this.comboBox_questionType.DisplayMember = "Multiple choice question";
            this.comboBox_questionType.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBox_questionType.FormattingEnabled = true;
            this.comboBox_questionType.Items.AddRange(new object[] {
            "Multiple choice question",
            "True or false question",
            "Open-ended question"});
            this.comboBox_questionType.Location = new System.Drawing.Point(113, 128);
            this.comboBox_questionType.Name = "comboBox_questionType";
            this.comboBox_questionType.Size = new System.Drawing.Size(522, 31);
            this.comboBox_questionType.TabIndex = 2;
            this.comboBox_questionType.ValueMember = "Multiple choice question";
            this.comboBox_questionType.SelectedIndexChanged += new System.EventHandler(this.comboBox_questionType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(107, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Question type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(107, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Correct answer";
            // 
            // textBox_correctAnswer
            // 
            this.textBox_correctAnswer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_correctAnswer.Location = new System.Drawing.Point(113, 399);
            this.textBox_correctAnswer.Multiline = true;
            this.textBox_correctAnswer.Name = "textBox_correctAnswer";
            this.textBox_correctAnswer.Size = new System.Drawing.Size(522, 52);
            this.textBox_correctAnswer.TabIndex = 4;
            // 
            // checkedListBox_correctAnswer
            // 
            this.checkedListBox_correctAnswer.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.checkedListBox_correctAnswer.FormattingEnabled = true;
            this.checkedListBox_correctAnswer.Location = new System.Drawing.Point(113, 458);
            this.checkedListBox_correctAnswer.Name = "checkedListBox_correctAnswer";
            this.checkedListBox_correctAnswer.Size = new System.Drawing.Size(522, 159);
            this.checkedListBox_correctAnswer.TabIndex = 6;
            // 
            // button_addCorrectAnswer
            // 
            this.button_addCorrectAnswer.BackColor = System.Drawing.Color.LimeGreen;
            this.button_addCorrectAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addCorrectAnswer.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_addCorrectAnswer.Location = new System.Drawing.Point(641, 399);
            this.button_addCorrectAnswer.Name = "button_addCorrectAnswer";
            this.button_addCorrectAnswer.Size = new System.Drawing.Size(59, 52);
            this.button_addCorrectAnswer.TabIndex = 8;
            this.button_addCorrectAnswer.Text = "+";
            this.button_addCorrectAnswer.UseVisualStyleBackColor = false;
            this.button_addCorrectAnswer.Click += new System.EventHandler(this.button_addCorrecttAnswer_Click);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.button_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_create.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button_create.Location = new System.Drawing.Point(265, 623);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(241, 67);
            this.button_create.TabIndex = 9;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // listView_correctAnswer
            // 
            this.listView_correctAnswer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.listView_correctAnswer.HideSelection = false;
            this.listView_correctAnswer.Location = new System.Drawing.Point(113, 458);
            this.listView_correctAnswer.Name = "listView_correctAnswer";
            this.listView_correctAnswer.Size = new System.Drawing.Size(522, 159);
            this.listView_correctAnswer.TabIndex = 10;
            this.listView_correctAnswer.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(210, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "CREATE QUESTION FORM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView_correctAnswer);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button_addCorrectAnswer);
            this.Controls.Add(this.checkedListBox_correctAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_correctAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_questionType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_questionText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_questionText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_questionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_correctAnswer;
        private System.Windows.Forms.CheckedListBox checkedListBox_correctAnswer;
        private System.Windows.Forms.Button button_addCorrectAnswer;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.ListView listView_correctAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}