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
    public partial class CreateQuestion : Form
    {
        private readonly int gameID;
        private readonly Question question = new Question();

        public static string QuestionTypeMultipleChoiceQuestion = "Multiple choice question";
        public static string QuestionTypeTrueFalseQuestion = "True or false question";
        public static string QuestionTypeOpenEndedQuestion = "Open-ended question";
        public CreateQuestion(int gameID)
        {
            InitializeComponent();
            this.gameID = gameID;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void comboBox_questionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedQuestionType = this.comboBox_questionType.SelectedItem;
            if (selectedQuestionType == null) // Default Open Ended question form
            {
                this.checkedListBox_correctAnswer.Hide();
                this.listView_correctAnswer.Clear();
                this.listView_correctAnswer.Show();
                this.textBox_correctAnswer.Clear();
                this.textBox_correctAnswer.Show();
                return;
            }

            if (selectedQuestionType.ToString() == QuestionTypeMultipleChoiceQuestion)
            {
                this.listView_correctAnswer.Hide();
                this.textBox_correctAnswer.Clear();
                this.textBox_correctAnswer.Show();
                this.button_addCorrectAnswer.Show();
                this.checkedListBox_correctAnswer.Items.Clear();
                this.checkedListBox_correctAnswer.Show();
            } else if (selectedQuestionType.ToString() == QuestionTypeTrueFalseQuestion)
            {
                this.listView_correctAnswer.Hide();
                this.textBox_correctAnswer.Hide();
                this.button_addCorrectAnswer.Hide();
                this.checkedListBox_correctAnswer.Items.Clear();
                this.checkedListBox_correctAnswer.Items.Add("TRUE", false);
                this.checkedListBox_correctAnswer.Items.Add("FALSE", false);
                this.checkedListBox_correctAnswer.Show();
            } else
            {
                this.listView_correctAnswer.Clear();
                this.listView_correctAnswer.Show();
                this.checkedListBox_correctAnswer.Hide();
                this.button_addCorrectAnswer.Show();
                this.textBox_correctAnswer.Clear();
                this.textBox_correctAnswer.Show();
            }
        }

        private void button_addCorrecttAnswer_Click(object sender, EventArgs e)
        {
            var correctAnswerValue = this.textBox_correctAnswer.Text;
            if (correctAnswerValue == "")
            {
                return;
            }
            if (this.comboBox_questionType.SelectedItem.ToString() == QuestionTypeMultipleChoiceQuestion)
            {
                this.checkedListBox_correctAnswer.Items.Add($"{correctAnswerValue}", false);
            } else if (this.comboBox_questionType.SelectedItem.ToString() == QuestionTypeOpenEndedQuestion)
            {
                this.listView_correctAnswer.Items.Add($"{correctAnswerValue}");
            }
            this.textBox_correctAnswer.Clear();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            var questionType = String.Empty;
            var questionText = String.Empty;
            var availableAnswer = String.Empty;
            var correctAnswer = String.Empty;

            if (this.comboBox_questionType.SelectedIndex == -1)
            {
                MessageBox.Show("Question type is invalid", "Input invalid", MessageBoxButtons.OK);
                return;
            }
            
            if (this.textBox_questionText.Text == "")
            {
                MessageBox.Show("Question text is empty", "Input invalid", MessageBoxButtons.OK);
                return;
            }
            questionText = this.textBox_questionText.Text;

            if (this.comboBox_questionType.SelectedItem.ToString() == QuestionTypeOpenEndedQuestion)
            {
                if (this.listView_correctAnswer.Items.Count == 0)
                {
                    MessageBox.Show("Correct answer is empty", "Input invalid", MessageBoxButtons.OK);
                    return;
                }
                correctAnswer = string.Join("||", this.listView_correctAnswer.Items.Cast<ListViewItem>().Select(s => s.Text));
                questionType = Question.QuestionTypeOpenEnded;

            } else if (this.comboBox_questionType.SelectedItem.ToString() == QuestionTypeTrueFalseQuestion)
            {
                if (this.checkedListBox_correctAnswer.CheckedItems.Count != 1)
                {
                    MessageBox.Show("Correct answer is invalid", "Input invalid", MessageBoxButtons.OK);
                    return;
                }
                availableAnswer = string.Join("||", this.checkedListBox_correctAnswer.Items.Cast<string>().ToList());
                correctAnswer = this.checkedListBox_correctAnswer.CheckedItems[0].ToString();
                questionType = Question.QuestionTypeTrueFalse;

            }
            else // Multiple choice question
            {
                if (this.checkedListBox_correctAnswer.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Correct answer is invalid", "Input invalid", MessageBoxButtons.OK);
                    return;
                }
                correctAnswer = string.Join("||", this.checkedListBox_correctAnswer.CheckedItems.Cast<object>().Select(item => item.ToString()));
                //questionText += "---";
                //questionText += string.Join("||", this.checkedListBox_correctAnswer.Items.Cast<object>().Select(item => item.ToString()));
                availableAnswer = string.Join("||",this.checkedListBox_correctAnswer.Items.Cast<string>().ToList());
                questionType = Question.QuestionTypeMultipleChoice;
            }
            
            question.CreateQuestion(this.gameID, questionText, questionType, availableAnswer, correctAnswer);
            MessageBox.Show("Create question successfully", "OK", MessageBoxButtons.OK);
            this.Hide();
            QuestionManage questionManage = new QuestionManage(gameID);
            questionManage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionManage questionManage = new QuestionManage(gameID);
            questionManage.Show();
        }
    }
}
