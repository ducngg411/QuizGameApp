using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGameApp
{
    public partial class UpdateQuestion : Form
    {
        private readonly Question question = new Question();

        public static string QuestionTypeMultipleChoiceQuestion = "Multiple choice question";
        public static string QuestionTypeTrueFalseQuestion = "True or false question";
        public static string QuestionTypeOpenEndedQuestion = "Open-ended question";

        private int questionId;
        private readonly int gameID;
        private string questionText;
        private string questionType;
        private string correctAnswer;

        public UpdateQuestion(int questionId, int gameId, string questionText, string questionType, string correctAnswer)
        {
            InitializeComponent();
            this.questionId = questionId;
            this.gameID = gameId;
            this.questionText = questionText;
            this.questionType = questionType;
            this.correctAnswer = correctAnswer;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FillData();
        }

        private void FillData()
        {
            comboBox_questionTypeUpdate.Text = questionType;
            textBox_questionTextUpdate.Text = questionText;
            textBox_correctAnswerUpdate.Text = correctAnswer;
        }

        // select type
        private void comboBox_questionTypeUpdate_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                var selectedQuestionType = this.comboBox_questionTypeUpdate.SelectedItem;
                if (selectedQuestionType == null) // Default Open Ended question form
                {
                    this.checkedListBox_correctAnswer.Hide();
                    this.listView_correctAnswerUpdate.Clear();
                    this.listView_correctAnswerUpdate.Show();
                    //this.textBox_correctAnswerUpdate.Clear();
                    this.textBox_correctAnswerUpdate.Show();
                    return;
                }

                if (selectedQuestionType.ToString() == QuestionTypeMultipleChoiceQuestion)
                {
                    this.listView_correctAnswerUpdate.Hide();
                    //this.textBox_correctAnswerUpdate.Clear();
                    this.textBox_correctAnswerUpdate.Show();
                    this.button_addCorrectAnswer.Show();
                    this.checkedListBox_correctAnswer.Items.Clear();
                    this.checkedListBox_correctAnswer.Show();
                }
                else if (selectedQuestionType.ToString() == QuestionTypeTrueFalseQuestion)
                {
                    this.listView_correctAnswerUpdate.Hide();
                    this.textBox_correctAnswerUpdate.Hide();
                    this.button_addCorrectAnswer.Hide();
                    this.checkedListBox_correctAnswer.Items.Clear();
                    this.checkedListBox_correctAnswer.Items.Add("TRUE", false);
                    this.checkedListBox_correctAnswer.Items.Add("FALSE", false);
                    this.checkedListBox_correctAnswer.Show();
                }
                else
                {
                    this.listView_correctAnswerUpdate.Clear();
                    this.listView_correctAnswerUpdate.Show();
                    this.checkedListBox_correctAnswer.Hide();
                    this.button_addCorrectAnswer.Show();
                    //this.textBox_correctAnswerUpdate.Clear();
                    this.textBox_correctAnswerUpdate.Show();
                }
            }
        }

        // add answer button
        private void button_addCorrectAnswer_Click(object sender, EventArgs e)
        {
            var correctAnswerValue = this.textBox_correctAnswerUpdate.Text;
            if (correctAnswerValue == "")
            {
                return;
            }
            if (this.comboBox_questionTypeUpdate.SelectedItem.ToString() == QuestionTypeMultipleChoiceQuestion)
            {
                this.checkedListBox_correctAnswer.Items.Add($"{correctAnswerValue}", false);
            }
            else if (this.comboBox_questionTypeUpdate.SelectedItem.ToString() == QuestionTypeOpenEndedQuestion)
            {
                this.listView_correctAnswerUpdate.Items.Add($"{correctAnswerValue}");
            }
            this.textBox_correctAnswerUpdate.Clear();
        }

        // back button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionManage questionManage = new QuestionManage(gameID);
            questionManage.Show();
        }

        // update button
        private void button_update_Click(object sender, EventArgs e)
        {
            var questionType = String.Empty;
            var questionText = String.Empty;
            var correctAnswer = String.Empty;

            if (this.comboBox_questionTypeUpdate.SelectedIndex == -1)
            {
                MessageBox.Show("Question type is invalid", "Input invalid", MessageBoxButtons.OK);
                return;
            }

            if (this.textBox_questionTextUpdate.Text == "")
            {
                MessageBox.Show("Question text is empty", "Input invalid", MessageBoxButtons.OK);
                return;
            }
            questionText = this.textBox_questionTextUpdate.Text;

            if (this.comboBox_questionTypeUpdate.SelectedItem.ToString() == QuestionTypeOpenEndedQuestion)
            {
                if (this.listView_correctAnswerUpdate.Items.Count == 0)
                {
                    MessageBox.Show("Correct answer is empty", "Input invalid", MessageBoxButtons.OK);
                    return;
                }
                correctAnswer = string.Join("||", this.listView_correctAnswerUpdate.Items.Cast<ListViewItem>().Select(s => s.Text));
                questionType = Question.QuestionTypeOpenEnded;

            }
            else if (this.comboBox_questionTypeUpdate.SelectedItem.ToString() == QuestionTypeTrueFalseQuestion)
            {
                if (this.checkedListBox_correctAnswer.CheckedItems.Count != 1)
                {
                    MessageBox.Show("Correct answer is invalid", "Input invalid", MessageBoxButtons.OK);
                    return;
                }
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
                questionText += "---";
                questionText += string.Join("||", this.checkedListBox_correctAnswer.Items.Cast<object>().Select(item => item.ToString()));
                questionType = Question.QuestionTypeMultipleChoice;
            }

            question.UpdateQuestion(questionId, this.gameID, questionText, questionType, correctAnswer);
            MessageBox.Show("Update question successfully!", "OK", MessageBoxButtons.OK);
            this.Hide();
            QuestionManage questionManage = new QuestionManage(gameID);
            questionManage.Show();
        }

        
    }
}
