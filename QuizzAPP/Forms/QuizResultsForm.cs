using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using QuizzAPP.Managers;
using QuizzAPP.Models;
using QuizzAPP.Utils;

namespace QuizzAPP.Forms
{
    public partial class QuizResultsForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private readonly ScoreManager _scoreManager;
        private readonly TimeTracker _timeTracker;

        public QuizResultsForm(ScoreManager scoreManager, TimeTracker timeTracker)
        {
            _scoreManager = scoreManager ?? throw new ArgumentNullException(nameof(scoreManager));
            _timeTracker = timeTracker ?? throw new ArgumentNullException(nameof(timeTracker));

            // Initialize Material Design
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);

            InitializeComponent();
            
            // Apply Material Design styling
            MaterialTheme.ApplyFormStyling(this);
            
            // Set form properties
            this.Text = "Quiz Results";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(700, 700);
            this.MinimumSize = new Size(700, 700);

            // Display results
            DisplayResults();
        }

        private void DisplayResults()
        {
            // Main score
            scoreLabel.Text = $"Score: {_scoreManager.ScoreFraction} ({_scoreManager.ScorePercentage:F1}%)";
            gradeLabel.Text = $"Grade: {_scoreManager.LetterGrade}";

            // Time information
            var totalTime = _timeTracker.TotalElapsed;
            timeLabel.Text = $"Total Time: {TimeTracker.FormatTime(totalTime)}";

            // Hide average time label since we don't track per-question time
            avgTimeLabel.Visible = false;

            // Show detailed answers instead of breakdown
            DisplayDetailedAnswers();

          
        }

        private void DisplayDetailedAnswers()
        {
            var results = _scoreManager.Results;

            // Clear existing content
            detailedResultsTextBox.Clear();

            for (int i = 0; i < results.Count; i++)
            {
                var result = results[i];
                var status = result.IsCorrect ? "✓" : "✗";
                var statusText = result.IsCorrect ? "Correct" : "Wrong";

                // Add question header with color
                AppendColoredText($"Q{i + 1}: {status} {statusText}\r\n",
                    result.IsCorrect ? Color.Green : Color.Red, true);

                // Add question text (black)
                AppendColoredText($"Question: {result.Question.QuestionText}\r\n", Color.Black, false);

                // Format user answer based on question type
                string userAnswerDisplay = FormatUserAnswer(result);

                // Add user answer with color based on correctness
                AppendColoredText("Your Answer: ", Color.Black, false);
                AppendColoredText($"{userAnswerDisplay}\r\n",
                    result.IsCorrect ? Color.Green : Color.Red, false);

                // Add correct answer (always green)
                AppendColoredText("Correct Answer: ", Color.Black, false);
                AppendColoredText($"{result.Question.CorrectAnswer}\r\n", Color.Green, false);

                // Add separator line between questions
                if (i < results.Count - 1)
                {
                    AppendColoredText("".PadRight(50, '-') + "\r\n", Color.Gray, false);
                }
                AppendColoredText("\r\n", Color.Black, false);
            }

            // Scroll to top
            detailedResultsTextBox.SelectionStart = 0;
            detailedResultsTextBox.ScrollToCaret();
        }

        // Helper method để thêm text với màu sắc vào RichTextBox
        private void AppendColoredText(string text, Color color, bool bold = false)
        {
            int startIndex = detailedResultsTextBox.TextLength;
            detailedResultsTextBox.AppendText(text);

            detailedResultsTextBox.Select(startIndex, text.Length);
            detailedResultsTextBox.SelectionColor = color;

            if (bold)
            {
                detailedResultsTextBox.SelectionFont = new Font(detailedResultsTextBox.Font, FontStyle.Bold);
            }
            else
            {
                detailedResultsTextBox.SelectionFont = new Font(detailedResultsTextBox.Font, FontStyle.Regular);
            }

            // Reset selection
            detailedResultsTextBox.Select(detailedResultsTextBox.TextLength, 0);
            detailedResultsTextBox.SelectionColor = Color.Black;
        }

        private string FormatUserAnswer(QuestionResult result)
        {
            if (result.Question is MultipleChoiceQuestion mcq)
            {
                // Convert index back to option text (chỉ hiển thị text, không có số)
                if (int.TryParse(result.UserAnswer, out int index) && index >= 0 && index < mcq.Options.Count)
                {
                    return mcq.Options[index];
                }
            }

            return result.UserAnswer;
        }

    



        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
