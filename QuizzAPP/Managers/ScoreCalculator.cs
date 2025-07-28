using System;
using System.Collections.Generic;
using System.Linq;
using QuizzAPP.Models;

namespace QuizzAPP.Managers
{
    /// <summary>
    /// Calculates and manages quiz scores - demonstrates Abstraction and Encapsulation
    /// </summary>
    public class ScoreCalculator
    {
        private List<QuestionResult> _results;

        /// <summary>
        /// Read-only access to question results
        /// </summary>
        public IReadOnlyList<QuestionResult> Results => _results.AsReadOnly();

        /// <summary>
        /// Total number of questions answered
        /// </summary>
        public int TotalQuestions => _results.Count;

        /// <summary>
        /// Number of correct answers
        /// </summary>
        public int CorrectAnswers => _results.Count(r => r.IsCorrect);

        /// <summary>
        /// Number of incorrect answers
        /// </summary>
        public int IncorrectAnswers => _results.Count(r => !r.IsCorrect);

        /// <summary>
        /// Score as percentage (0-100)
        /// </summary>
        public double ScorePercentage => TotalQuestions > 0 ? (double)CorrectAnswers / TotalQuestions * 100 : 0;

        /// <summary>
        /// Score as fraction (e.g., "8/10")
        /// </summary>
        public string ScoreFraction => $"{CorrectAnswers}/{TotalQuestions}";

        /// <summary>
        /// Letter grade based on percentage
        /// </summary>
        public string LetterGrade => GetLetterGrade(ScorePercentage);

        /// <summary>
        /// Constructor initializes empty results
        /// </summary>
        public ScoreCalculator()
        {
            _results = new List<QuestionResult>();
        }

        /// <summary>
        /// Record the result of answering a question
        /// </summary>
        /// <param name="question">The question that was answered</param>
        /// <param name="userAnswer">The user's answer</param>
        /// <param name="isCorrect">Whether the answer was correct</param>
        /// <param name="timeSpent">Time spent on this question</param>
        public void RecordAnswer(Question question, string userAnswer, bool isCorrect, TimeSpan timeSpent)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question));

            var result = new QuestionResult
            {
                Question = question,
                UserAnswer = userAnswer ?? string.Empty,
                IsCorrect = isCorrect,
                TimeSpent = timeSpent,
                AnsweredAt = DateTime.Now
            };

            _results.Add(result);
        }

        /// <summary>
        /// Clear all recorded results
        /// </summary>
        public void Reset()
        {
            _results.Clear();
        }

        /// <summary>
        /// Get results for a specific question type
        /// </summary>
        /// <param name="questionType">Type of questions to filter by</param>
        /// <returns>Results for the specified question type</returns>
        public List<QuestionResult> GetResultsByType(string questionType)
        {
            return _results.Where(r => r.Question.QuestionType.Equals(questionType, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// Get detailed score breakdown by question type
        /// </summary>
        /// <returns>Score breakdown</returns>
        public ScoreBreakdown GetScoreBreakdown()
        {
            var breakdown = new ScoreBreakdown();

            var multipleChoiceResults = GetResultsByType("Multiple Choice");
            var openEndedResults = GetResultsByType("Open Ended");
            var trueFalseResults = GetResultsByType("True/False");

            breakdown.MultipleChoice = new TypeScore
            {
                Correct = multipleChoiceResults.Count(r => r.IsCorrect),
                Total = multipleChoiceResults.Count
            };

            breakdown.OpenEnded = new TypeScore
            {
                Correct = openEndedResults.Count(r => r.IsCorrect),
                Total = openEndedResults.Count
            };

            breakdown.TrueFalse = new TypeScore
            {
                Correct = trueFalseResults.Count(r => r.IsCorrect),
                Total = trueFalseResults.Count
            };

            breakdown.Overall = new TypeScore
            {
                Correct = CorrectAnswers,
                Total = TotalQuestions
            };

            return breakdown;
        }

        /// <summary>
        /// Get average time spent per question
        /// </summary>
        /// <returns>Average time per question</returns>
        public TimeSpan GetAverageTimePerQuestion()
        {
            if (_results.Count == 0)
                return TimeSpan.Zero;

            var totalTicks = _results.Sum(r => r.TimeSpent.Ticks);
            return new TimeSpan(totalTicks / _results.Count);
        }

        /// <summary>
        /// Get total time spent on all questions
        /// </summary>
        /// <returns>Total time spent</returns>
        public TimeSpan GetTotalTimeSpent()
        {
            return new TimeSpan(_results.Sum(r => r.TimeSpent.Ticks));
        }

        /// <summary>
        /// Get performance summary
        /// </summary>
        /// <returns>Performance summary string</returns>
        public string GetPerformanceSummary()
        {
            if (TotalQuestions == 0)
                return "No questions answered yet.";

            var totalTime = GetTotalTimeSpent();
            var avgTime = GetAverageTimePerQuestion();

            return $"Score: {ScoreFraction} ({ScorePercentage:F1}%) - Grade: {LetterGrade}\n" +
                   $"Total Time: {totalTime.TotalMinutes:F1} minutes\n" +
                   $"Average Time per Question: {avgTime.TotalSeconds:F1} seconds";
        }

        /// <summary>
        /// Convert percentage to letter grade
        /// </summary>
        /// <param name="percentage">Score percentage</param>
        /// <returns>Letter grade</returns>
        private string GetLetterGrade(double percentage)
        {
            return percentage switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
        }
    }

    /// <summary>
    /// Represents the result of answering a single question
    /// </summary>
    public class QuestionResult
    {
        public Question Question { get; set; } = null!;
        public string UserAnswer { get; set; } = string.Empty;
        public bool IsCorrect { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public DateTime AnsweredAt { get; set; }
    }

    /// <summary>
    /// Score breakdown by question type
    /// </summary>
    public class ScoreBreakdown
    {
        public TypeScore MultipleChoice { get; set; } = new();
        public TypeScore OpenEnded { get; set; } = new();
        public TypeScore TrueFalse { get; set; } = new();
        public TypeScore Overall { get; set; } = new();
    }

    /// <summary>
    /// Score for a specific question type
    /// </summary>
    public class TypeScore
    {
        public int Correct { get; set; }
        public int Total { get; set; }
        public double Percentage => Total > 0 ? (double)Correct / Total * 100 : 0;
        public string Fraction => $"{Correct}/{Total}";
    }
}
