namespace QuizGameApp
{
    partial class QuestionManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionManage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label_questionManage = new System.Windows.Forms.Label();
            this.dataGridView_questionList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_addQuestion = new System.Windows.Forms.Button();
            this.button_editQuestion = new System.Windows.Forms.Button();
            this.button_deleteQuestion = new System.Windows.Forms.Button();
            this.button_saveQuestion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_questionList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label_questionManage);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 73);
            this.panel1.TabIndex = 2;
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
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_questionManage
            // 
            this.label_questionManage.AutoSize = true;
            this.label_questionManage.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label_questionManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.label_questionManage.Location = new System.Drawing.Point(237, 21);
            this.label_questionManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_questionManage.Name = "label_questionManage";
            this.label_questionManage.Size = new System.Drawing.Size(466, 28);
            this.label_questionManage.TabIndex = 0;
            this.label_questionManage.Text = "PLACEHOLDER Question manage name";
            // 
            // dataGridView_questionList
            // 
            this.dataGridView_questionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_questionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_questionList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_questionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_questionList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_questionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_questionList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_questionList.Location = new System.Drawing.Point(2, 76);
            this.dataGridView_questionList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_questionList.Name = "dataGridView_questionList";
            this.dataGridView_questionList.RowHeadersWidth = 120;
            this.dataGridView_questionList.RowTemplate.Height = 24;
            this.dataGridView_questionList.Size = new System.Drawing.Size(932, 286);
            this.dataGridView_questionList.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(2, 362);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 20);
            this.panel2.TabIndex = 4;
            // 
            // button_addQuestion
            // 
            this.button_addQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_addQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addQuestion.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_addQuestion.ForeColor = System.Drawing.Color.White;
            this.button_addQuestion.Location = new System.Drawing.Point(69, 466);
            this.button_addQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.button_addQuestion.Name = "button_addQuestion";
            this.button_addQuestion.Size = new System.Drawing.Size(122, 98);
            this.button_addQuestion.TabIndex = 8;
            this.button_addQuestion.Text = "Add Quesition";
            this.button_addQuestion.UseVisualStyleBackColor = false;
            this.button_addQuestion.Click += new System.EventHandler(this.button_addQuestion_Click);
            // 
            // button_editQuestion
            // 
            this.button_editQuestion.BackColor = System.Drawing.Color.ForestGreen;
            this.button_editQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editQuestion.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_editQuestion.ForeColor = System.Drawing.Color.White;
            this.button_editQuestion.Location = new System.Drawing.Point(294, 466);
            this.button_editQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.button_editQuestion.Name = "button_editQuestion";
            this.button_editQuestion.Size = new System.Drawing.Size(122, 98);
            this.button_editQuestion.TabIndex = 9;
            this.button_editQuestion.Text = "Edit Question";
            this.button_editQuestion.UseVisualStyleBackColor = false;
            this.button_editQuestion.Click += new System.EventHandler(this.button_editQuestion_Click);
            // 
            // button_deleteQuestion
            // 
            this.button_deleteQuestion.BackColor = System.Drawing.Color.Red;
            this.button_deleteQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_deleteQuestion.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_deleteQuestion.ForeColor = System.Drawing.Color.White;
            this.button_deleteQuestion.Location = new System.Drawing.Point(518, 466);
            this.button_deleteQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.button_deleteQuestion.Name = "button_deleteQuestion";
            this.button_deleteQuestion.Size = new System.Drawing.Size(122, 98);
            this.button_deleteQuestion.TabIndex = 10;
            this.button_deleteQuestion.Text = "Delete Question";
            this.button_deleteQuestion.UseVisualStyleBackColor = false;
            this.button_deleteQuestion.Click += new System.EventHandler(this.button_deleteQuestion_Click);
            // 
            // button_saveQuestion
            // 
            this.button_saveQuestion.BackColor = System.Drawing.Color.Fuchsia;
            this.button_saveQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_saveQuestion.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_saveQuestion.ForeColor = System.Drawing.Color.White;
            this.button_saveQuestion.Location = new System.Drawing.Point(730, 466);
            this.button_saveQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.button_saveQuestion.Name = "button_saveQuestion";
            this.button_saveQuestion.Size = new System.Drawing.Size(122, 98);
            this.button_saveQuestion.TabIndex = 11;
            this.button_saveQuestion.Text = "Save All";
            this.button_saveQuestion.UseVisualStyleBackColor = false;
            this.button_saveQuestion.Click += new System.EventHandler(this.button_saveQuestion_Click);
            // 
            // QuestionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(937, 612);
            this.Controls.Add(this.button_saveQuestion);
            this.Controls.Add(this.button_deleteQuestion);
            this.Controls.Add(this.button_editQuestion);
            this.Controls.Add(this.button_addQuestion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_questionList);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuestionManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionManage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_questionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_questionManage;
        private System.Windows.Forms.DataGridView dataGridView_questionList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_addQuestion;
        private System.Windows.Forms.Button button_editQuestion;
        private System.Windows.Forms.Button button_deleteQuestion;
        private System.Windows.Forms.Button button_saveQuestion;
        private System.Windows.Forms.Button button1;
    }
}