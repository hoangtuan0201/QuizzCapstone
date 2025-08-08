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
    public partial class PlayGameForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private readonly QuizManager _quizManager;
        private readonly ScoreManager _scoreManager;
        private readonly TimeTracker _timeTracker;

        private List<Question> _questions = new List<Question>();
        private int _currentQuestionIndex;
        private Question _currentQuestion = null!;

        public PlayGameForm(QuizManager quizManager)
        {
            _quizManager = quizManager ?? throw new ArgumentNullException(nameof(quizManager));
            _scoreManager = new ScoreManager();
            _timeTracker = new TimeTracker();

            // Initialize Material Design
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);

            InitializeComponent();
            
            // Apply Material Design styling
            MaterialTheme.ApplyFormStyling(this);
            
            // Set form properties
            this.Text = "Play Quiz";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(1000, 750);
            this.MinimumSize = new Size(900, 650);
            this.WindowState = FormWindowState.Normal;

            // Initialize quiz
            InitializeQuiz();
        }

        private void InitializeQuiz()
        {
            _questions = _quizManager.GetShuffledQuestions();
            _currentQuestionIndex = 0;
            
            if (_questions.Count == 0)
            {
                MessageBox.Show("No questions available!", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _timeTracker.StartQuiz();
            ShowCurrentQuestion();
        }

        private void ShowCurrentQuestion()
        {
            if (_currentQuestionIndex >= _questions.Count)
            {
                ShowResults();
                return;
            }

            _currentQuestion = _questions[_currentQuestionIndex];

            // Update progress
            progressLabel.Text = $"Question {_currentQuestionIndex + 1} of {_questions.Count}";
            
            // Show question
            questionLabel.Text = _currentQuestion.GetDisplayText();
            
            // Show appropriate answer controls
            ShowAnswerControls();
        }

        private void ShowAnswerControls()
        {
            // Hide all answer controls first
            multipleChoicePanel.Visible = false;
            openEndedPanel.Visible = false;
            trueFalsePanel.Visible = false;

            switch (_currentQuestion)
            {
                case MultipleChoiceQuestion mcq:
                    ShowMultipleChoiceControls(mcq);
                    break;
                case OpenEndedQuestion:
                    ShowOpenEndedControls();
                    break;
                case TrueFalseQuestion:
                    ShowTrueFalseControls();
                    break;
            }
        }

        private void ShowMultipleChoiceControls(MultipleChoiceQuestion mcq)
        {
            multipleChoicePanel.Visible = true;
            
            option1RadioButton.Text = $"1. {mcq.Options[0]}";
            option2RadioButton.Text = $"2. {mcq.Options[1]}";
            option3RadioButton.Text = $"3. {mcq.Options[2]}";
            option4RadioButton.Text = $"4. {mcq.Options[3]}";
            
            // Clear previous selection
            option1RadioButton.Checked = false;
            option2RadioButton.Checked = false;
            option3RadioButton.Checked = false;
            option4RadioButton.Checked = false;
        }

        private void ShowOpenEndedControls()
        {
            openEndedPanel.Visible = true;
            answerTextBox.Text = "";
            answerTextBox.Focus();
        }

        private void ShowTrueFalseControls()
        {
            trueFalsePanel.Visible = true;
            trueRadioButton.Checked = false;
            falseRadioButton.Checked = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string userAnswer = GetUserAnswer();
            
            if (string.IsNullOrWhiteSpace(userAnswer))
            {
                MessageBox.Show("Please provide an answer before submitting.", "No Answer", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Record result
            bool isCorrect = _currentQuestion.IsAnswerCorrect(userAnswer);

            _scoreManager.RecordAnswer(_currentQuestion, userAnswer, isCorrect, TimeSpan.Zero);

            // Move to next question
            _currentQuestionIndex++;
            ShowCurrentQuestion();
        }

        private string GetUserAnswer()
        {
            if (_currentQuestion is MultipleChoiceQuestion)
            {
                return GetMultipleChoiceAnswer();
            }
            else if (_currentQuestion is OpenEndedQuestion)
            {
                return answerTextBox.Text.Trim();
            }
            else if (_currentQuestion is TrueFalseQuestion)
            {
                return GetTrueFalseAnswer();
            }
            else
            {
                return string.Empty;
            }
        }

        private string GetMultipleChoiceAnswer()
        {
            if (option1RadioButton.Checked) return "0";
            if (option2RadioButton.Checked) return "1";
            if (option3RadioButton.Checked) return "2";
            if (option4RadioButton.Checked) return "3";
            return string.Empty;
        }

        private string GetTrueFalseAnswer()
        {
            if (trueRadioButton.Checked) return "True";
            if (falseRadioButton.Checked) return "False";
            return string.Empty;
        }

        private void ShowResults()
        {
            _timeTracker.StopQuiz();

            var resultsForm = new QuizResultsForm(_scoreManager, _timeTracker, _quizManager);
            resultsForm.ShowDialog();

            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the quiz? Your progress will be lost.", 
                                       "Exit Quiz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                _timeTracker.StopQuiz();
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _timeTracker.StopQuiz();
            base.OnFormClosing(e);
        }
    }
}
