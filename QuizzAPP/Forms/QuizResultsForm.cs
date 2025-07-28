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
        private readonly ScoreCalculator _scoreCalculator;
        private readonly TimeTracker _timeTracker;

        public QuizResultsForm(ScoreCalculator scoreCalculator, TimeTracker timeTracker)
        {
            _scoreCalculator = scoreCalculator ?? throw new ArgumentNullException(nameof(scoreCalculator));
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
            scoreLabel.Text = $"Score: {_scoreCalculator.ScoreFraction} ({_scoreCalculator.ScorePercentage:F1}%)";
            gradeLabel.Text = $"Grade: {_scoreCalculator.LetterGrade}";

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
            var results = _scoreCalculator.Results;
            var detailsText = "";

            for (int i = 0; i < results.Count; i++)
            {
                var result = results[i];
                var status = result.IsCorrect ? "✓" : "✗";
                var statusText = result.IsCorrect ? "Correct" : "Wrong";

                detailsText += $"Q{i + 1}: {status} {statusText}\r\n";
                detailsText += $"Question: {result.Question.QuestionText}\r\n";

                // Format user answer based on question type
                string userAnswerDisplay = FormatUserAnswer(result);
                detailsText += $"Your Answer: {userAnswerDisplay}\r\n";
                detailsText += $"Correct Answer: {result.Question.CorrectAnswer}\r\n";

                // Add separator line between questions
                if (i < results.Count - 1)
                {
                    detailsText += "".PadRight(50, '-') + "\r\n";
                }
                detailsText += "\r\n";
            }

            detailedResultsTextBox.Text = detailsText.TrimEnd();
            detailedResultsTextBox.SelectionStart = 0;
            detailedResultsTextBox.ScrollToCaret();
        }

        private string FormatUserAnswer(QuestionResult result)
        {
            if (result.Question is MultipleChoiceQuestion mcq)
            {
                // Convert index back to option text
                if (int.TryParse(result.UserAnswer, out int index) && index >= 0 && index < mcq.Options.Count)
                {
                    return $"{index + 1}. {mcq.Options[index]}";
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
