namespace QuizGameApp
{
    partial class CreateNewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_showGameList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_gameName = new System.Windows.Forms.TextBox();
            this.textBox_gameDescription = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_deleteGame = new System.Windows.Forms.Button();
            this.button_editGame = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showGameList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 73);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(2, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(356, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Manage";
            // 
            // dataGridView_showGameList
            // 
            this.dataGridView_showGameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_showGameList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_showGameList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_showGameList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_showGameList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_showGameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showGameList.Location = new System.Drawing.Point(2, 74);
            this.dataGridView_showGameList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_showGameList.Name = "dataGridView_showGameList";
            this.dataGridView_showGameList.RowHeadersWidth = 120;
            this.dataGridView_showGameList.RowTemplate.Height = 24;
            this.dataGridView_showGameList.Size = new System.Drawing.Size(932, 286);
            this.dataGridView_showGameList.TabIndex = 2;
            this.dataGridView_showGameList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(2, 358);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 20);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(10, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(10, 474);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // textBox_gameName
            // 
            this.textBox_gameName.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox_gameName.Location = new System.Drawing.Point(163, 396);
            this.textBox_gameName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_gameName.Name = "textBox_gameName";
            this.textBox_gameName.Size = new System.Drawing.Size(393, 34);
            this.textBox_gameName.TabIndex = 5;
            // 
            // textBox_gameDescription
            // 
            this.textBox_gameDescription.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox_gameDescription.Location = new System.Drawing.Point(163, 474);
            this.textBox_gameDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_gameDescription.Multiline = true;
            this.textBox_gameDescription.Name = "textBox_gameDescription";
            this.textBox_gameDescription.Size = new System.Drawing.Size(393, 128);
            this.textBox_gameDescription.TabIndex = 6;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(605, 437);
            this.button_clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(122, 42);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click_1);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_add.Location = new System.Drawing.Point(605, 506);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(122, 42);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_deleteGame
            // 
            this.button_deleteGame.BackColor = System.Drawing.Color.Red;
            this.button_deleteGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_deleteGame.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_deleteGame.Location = new System.Drawing.Point(770, 437);
            this.button_deleteGame.Margin = new System.Windows.Forms.Padding(2);
            this.button_deleteGame.Name = "button_deleteGame";
            this.button_deleteGame.Size = new System.Drawing.Size(122, 42);
            this.button_deleteGame.TabIndex = 9;
            this.button_deleteGame.Text = "Delete";
            this.button_deleteGame.UseVisualStyleBackColor = false;
            this.button_deleteGame.Click += new System.EventHandler(this.button_deleteGame_Click);
            // 
            // button_editGame
            // 
            this.button_editGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.button_editGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editGame.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.button_editGame.Location = new System.Drawing.Point(770, 506);
            this.button_editGame.Margin = new System.Windows.Forms.Padding(2);
            this.button_editGame.Name = "button_editGame";
            this.button_editGame.Size = new System.Drawing.Size(122, 42);
            this.button_editGame.TabIndex = 10;
            this.button_editGame.Text = "Edit";
            this.button_editGame.UseVisualStyleBackColor = false;
            this.button_editGame.Click += new System.EventHandler(this.button_editGame_Click);
            // 
            // CreateNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 612);
            this.Controls.Add(this.button_editGame);
            this.Controls.Add(this.button_deleteGame);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_gameDescription);
            this.Controls.Add(this.textBox_gameName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_showGameList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewGame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showGameList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_showGameList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_gameName;
        private System.Windows.Forms.TextBox textBox_gameDescription;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_deleteGame;
        private System.Windows.Forms.Button button_editGame;
    }
}