using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using QuizzAPP.Managers;
using QuizzAPP.Models;
using QuizzAPP.Utils;

namespace QuizzAPP.Forms
{
    public partial class QuestionEditForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private readonly QuizManager _quizManager;
        private readonly Question? _existingQuestion;
        private bool _isEditMode;

        public QuestionEditForm(QuizManager quizManager, Question? existingQuestion = null)
        {
            _quizManager = quizManager ?? throw new ArgumentNullException(nameof(quizManager));
            _existingQuestion = existingQuestion;
            _isEditMode = existingQuestion != null;

            // Initialize Material Design
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);

            InitializeComponent();
            
            // Apply Material Design styling
            MaterialTheme.ApplyFormStyling(this);
            
            // Set form properties
            this.Text = _isEditMode ? "Edit Question" : "Add New Question";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(900, 750);
            this.MinimumSize = new Size(800, 650);
            this.WindowState = FormWindowState.Normal;

            // Initialize form
            InitializeQuestionTypes();
            
            if (_isEditMode && _existingQuestion != null)
            {
                LoadExistingQuestion(_existingQuestion);
            }
            else
            {
                // Default to Multiple Choice
                questionTypeComboBox.SelectedIndex = 0;
            }
        }

        private void InitializeQuestionTypes()
        {
            questionTypeComboBox.Items.Clear();
            questionTypeComboBox.Items.Add("Multiple Choice");
            questionTypeComboBox.Items.Add("Open Ended");
            questionTypeComboBox.Items.Add("True/False");
        }

        private void LoadExistingQuestion(Question question)
        {
            questionTextBox.Text = question.QuestionText;
            
            switch (question)
            {
                case MultipleChoiceQuestion mcq:
                    questionTypeComboBox.SelectedIndex = 0;
                    LoadMultipleChoiceQuestion(mcq);
                    break;
                case OpenEndedQuestion oeq:
                    questionTypeComboBox.SelectedIndex = 1;
                    LoadOpenEndedQuestion(oeq);
                    break;
                case TrueFalseQuestion tfq:
                    questionTypeComboBox.SelectedIndex = 2;
                    LoadTrueFalseQuestion(tfq);
                    break;
            }
        }

        private void LoadMultipleChoiceQuestion(MultipleChoiceQuestion mcq)
        {
            option1TextBox.Text = mcq.Options[0];
            option2TextBox.Text = mcq.Options[1];
            option3TextBox.Text = mcq.Options[2];
            option4TextBox.Text = mcq.Options[3];
            
            correctAnswerComboBox.SelectedIndex = mcq.CorrectOptionIndex;
        }

        private void LoadOpenEndedQuestion(OpenEndedQuestion oeq)
        {
            correctAnswerTextBox.Text = oeq.CorrectAnswer;
            alternativeAnswersTextBox.Text = string.Join(", ", oeq.AlternativeAnswers);
        }

        private void LoadTrueFalseQuestion(TrueFalseQuestion tfq)
        {
            trueFalseComboBox.SelectedIndex = tfq.IsTrue ? 0 : 1;
        }

        private void questionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowQuestionTypeControls();
        }

        private void ShowQuestionTypeControls()
        {
            // Hide all type-specific controls first
            multipleChoicePanel.Visible = false;
            openEndedPanel.Visible = false;
            trueFalsePanel.Visible = false;

            switch (questionTypeComboBox.SelectedIndex)
            {
                case 0: // Multiple Choice
                    multipleChoicePanel.Visible = true;
                    SetupMultipleChoiceControls();
                    break;
                case 1: // Open Ended
                    openEndedPanel.Visible = true;
                    break;
                case 2: // True/False
                    trueFalsePanel.Visible = true;
                    SetupTrueFalseControls();
                    break;
            }
        }

        private void SetupMultipleChoiceControls()
        {
            correctAnswerComboBox.Items.Clear();
            correctAnswerComboBox.Items.Add("Option 1");
            correctAnswerComboBox.Items.Add("Option 2");
            correctAnswerComboBox.Items.Add("Option 3");
            correctAnswerComboBox.Items.Add("Option 4");
            
            if (correctAnswerComboBox.SelectedIndex < 0)
                correctAnswerComboBox.SelectedIndex = 0;
        }

        private void SetupTrueFalseControls()
        {
            trueFalseComboBox.Items.Clear();
            trueFalseComboBox.Items.Add("True");
            trueFalseComboBox.Items.Add("False");
            
            if (trueFalseComboBox.SelectedIndex < 0)
                trueFalseComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                Question question = CreateQuestionFromInput();
                
                if (_isEditMode && _existingQuestion != null)
                {
                    question.Id = _existingQuestion.Id;
                    _quizManager.UpdateQuestion(question);
                }
                else
                {
                    _quizManager.AddQuestion(question);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving question: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(questionTextBox.Text))
            {
                MessageBox.Show("Please enter a question.", "Validation Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                questionTextBox.Focus();
                return false;
            }

            switch (questionTypeComboBox.SelectedIndex)
            {
                case 0: // Multiple Choice
                    return ValidateMultipleChoice();
                case 1: // Open Ended
                    return ValidateOpenEnded();
                case 2: // True/False
                    return ValidateTrueFalse();
                default:
                    return false;
            }
        }

        private bool ValidateMultipleChoice()
        {
            var options = new[] { option1TextBox.Text, option2TextBox.Text, option3TextBox.Text, option4TextBox.Text };
            
            if (options.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Please fill in all four options.", "Validation Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (correctAnswerComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the correct answer.", "Validation Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateOpenEnded()
        {
            if (string.IsNullOrWhiteSpace(correctAnswerTextBox.Text))
            {
                MessageBox.Show("Please enter the correct answer.", "Validation Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                correctAnswerTextBox.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateTrueFalse()
        {
            if (trueFalseComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select True or False.", "Validation Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private Question CreateQuestionFromInput()
        {
            string questionText = questionTextBox.Text.Trim();

            if (questionTypeComboBox.SelectedIndex == 0)
            {
                return CreateMultipleChoiceQuestion(questionText);
            }
            else if (questionTypeComboBox.SelectedIndex == 1)
            {
                return CreateOpenEndedQuestion(questionText);
            }
            else if (questionTypeComboBox.SelectedIndex == 2)
            {
                return CreateTrueFalseQuestion(questionText);
            }
            else
            {
                throw new InvalidOperationException("Invalid question type selected.");
            }
        }

        private MultipleChoiceQuestion CreateMultipleChoiceQuestion(string questionText)
        {
            var options = new List<string>
            {
                option1TextBox.Text.Trim(),
                option2TextBox.Text.Trim(),
                option3TextBox.Text.Trim(),
                option4TextBox.Text.Trim()
            };

            return new MultipleChoiceQuestion(0, questionText, options, correctAnswerComboBox.SelectedIndex);
        }

        private OpenEndedQuestion CreateOpenEndedQuestion(string questionText)
        {
            string correctAnswer = correctAnswerTextBox.Text.Trim();
            var alternatives = new List<string>();

            if (!string.IsNullOrWhiteSpace(alternativeAnswersTextBox.Text))
            {
                alternatives = alternativeAnswersTextBox.Text
                    .Split(',')
                    .Select(s =>
                    {
                        return s.Trim();
                    })
                    .Where(s =>
                    {
                        return !string.IsNullOrEmpty(s);
                    })
                    .ToList();
            }

            return new OpenEndedQuestion(0, questionText, correctAnswer, alternatives);
        }

        private TrueFalseQuestion CreateTrueFalseQuestion(string questionText)
        {
            bool isTrue = trueFalseComboBox.SelectedIndex == 0;
            return new TrueFalseQuestion(0, questionText, isTrue);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void trueFalseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Không cần xử lý gì đặc biệt cho True/False ComboBox
            // Giá trị sẽ được lấy khi save
        }
    }
}
