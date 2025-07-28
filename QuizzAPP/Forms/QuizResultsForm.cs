using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using QuizzAPP.Managers;
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
            this.Size = new Size(600, 500);
            this.MinimumSize = new Size(500, 400);

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
            timeLabel.Text = $"Total Time: {TimeTracker.FormatTime(totalTime)} ({totalTime.TotalMinutes:F1} minutes)";
            
            var avgTime = _scoreCalculator.GetAverageTimePerQuestion();
            avgTimeLabel.Text = $"Average Time per Question: {TimeTracker.FormatTime(avgTime)}";

            // Detailed breakdown
            var breakdown = _scoreCalculator.GetScoreBreakdown();
            breakdownLabel.Text = $"Multiple Choice: {breakdown.MultipleChoice.Fraction} ({breakdown.MultipleChoice.Percentage:F1}%)\n" +
                                 $"Open Ended: {breakdown.OpenEnded.Fraction} ({breakdown.OpenEnded.Percentage:F1}%)\n" +
                                 $"True/False: {breakdown.TrueFalse.Fraction} ({breakdown.TrueFalse.Percentage:F1}%)";

            // Performance message
            string performanceMessage = GetPerformanceMessage(_scoreCalculator.ScorePercentage);
            performanceLabel.Text = performanceMessage;
            
            // Set performance label color based on score
            if (_scoreCalculator.ScorePercentage >= 80)
                performanceLabel.ForeColor = MaterialTheme.SuccessColor;
            else if (_scoreCalculator.ScorePercentage >= 60)
                performanceLabel.ForeColor = MaterialTheme.WarningColor;
            else
                performanceLabel.ForeColor = MaterialTheme.ErrorColor;
        }

        private string GetPerformanceMessage(double percentage)
        {
            return percentage switch
            {
                >= 90 => "Excellent work! You have a strong understanding of geography.",
                >= 80 => "Great job! You performed very well on this quiz.",
                >= 70 => "Good work! You have a solid grasp of the material.",
                >= 60 => "Not bad! Consider reviewing the topics you missed.",
                >= 50 => "You're getting there! More practice will help improve your score.",
                _ => "Keep studying! Review the material and try again."
            };
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
