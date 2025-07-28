using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizzAPP.Models
{
    /// <summary>
    /// Open-ended question implementation - demonstrates Inheritance
    /// Supports alternative correct answers (e.g., "United Kingdom" and "UK")
    /// </summary>
    public class OpenEndedQuestion : Question
    {
        private List<string> _alternativeAnswers = new List<string>();

        /// <summary>
        /// List of alternative correct answers - demonstrates Encapsulation
        /// </summary>
        public List<string> AlternativeAnswers
        {
            get => _alternativeAnswers;
            set => _alternativeAnswers = value ?? new List<string>();
        }

        /// <summary>
        /// Question type identifier
        /// </summary>
        public override string QuestionType => "Open Ended";

        /// <summary>
        /// Constructor for Open Ended Question
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="questionText">The question text</param>
        /// <param name="correctAnswer">The primary correct answer</param>
        /// <param name="alternativeAnswers">Optional list of alternative correct answers</param>
        public OpenEndedQuestion(int id, string questionText, string correctAnswer, List<string>? alternativeAnswers = null)
            : base(id, questionText, correctAnswer)
        {
            AlternativeAnswers = alternativeAnswers ?? new List<string>();
        }

        /// <summary>
        /// Check if the provided answer is correct - implements abstract method
        /// Supports multiple correct answer variations
        /// </summary>
        /// <param name="userAnswer">The user's answer</param>
        /// <returns>True if correct, false otherwise</returns>
        public override bool IsAnswerCorrect(string userAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            string normalizedUserAnswer = NormalizeAnswer(userAnswer);
            string normalizedCorrectAnswer = NormalizeAnswer(CorrectAnswer);

            // Check primary answer
            if (normalizedUserAnswer == normalizedCorrectAnswer)
                return true;

            // Check alternative answers
            return AlternativeAnswers.Any(alt => NormalizeAnswer(alt) == normalizedUserAnswer);
        }

        /// <summary>
        /// Normalize answer for comparison (remove extra spaces, convert to lowercase, etc.)
        /// </summary>
        /// <param name="answer">Raw answer</param>
        /// <returns>Normalized answer</returns>
        private string NormalizeAnswer(string answer)
        {
            if (string.IsNullOrWhiteSpace(answer))
                return string.Empty;

            return answer.Trim()
                        .ToLowerInvariant()
                        .Replace("  ", " ") // Replace double spaces with single space
                        .Replace(".", "") // Remove periods
                        .Replace(",", ""); // Remove commas
        }

        /// <summary>
        /// Add an alternative correct answer
        /// </summary>
        /// <param name="alternativeAnswer">Alternative answer to add</param>
        public void AddAlternativeAnswer(string alternativeAnswer)
        {
            if (string.IsNullOrWhiteSpace(alternativeAnswer))
                throw new ArgumentException("Alternative answer cannot be null or empty.");

            if (!AlternativeAnswers.Contains(alternativeAnswer, StringComparer.OrdinalIgnoreCase))
            {
                AlternativeAnswers.Add(alternativeAnswer);
            }
        }

        /// <summary>
        /// Remove an alternative answer
        /// </summary>
        /// <param name="alternativeAnswer">Alternative answer to remove</param>
        public void RemoveAlternativeAnswer(string alternativeAnswer)
        {
            AlternativeAnswers.RemoveAll(alt => 
                string.Equals(alt, alternativeAnswer, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Get all possible correct answers (primary + alternatives)
        /// </summary>
        /// <returns>List of all correct answers</returns>
        public List<string> GetAllCorrectAnswers()
        {
            var allAnswers = new List<string> { CorrectAnswer };
            allAnswers.AddRange(AlternativeAnswers);
            return allAnswers;
        }

        /// <summary>
        /// Get formatted display text
        /// </summary>
        /// <returns>Question text with instruction</returns>
        public override string GetDisplayText()
        {
            return base.GetDisplayText() + "\n(Enter your answer - 1 to 4 words)";
        }

        /// <summary>
        /// Validate that the answer length is appropriate (1-4 words)
        /// </summary>
        /// <param name="answer">Answer to validate</param>
        /// <returns>True if valid length</returns>
        public bool IsAnswerLengthValid(string answer)
        {
            if (string.IsNullOrWhiteSpace(answer))
                return false;

            string[] words = answer.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length >= 1 && words.Length <= 4;
        }
    }
}
