using System;

namespace QuizzAPP.Models
{
    /// <summary>
    /// True/False question implementation - demonstrates Inheritance
    /// </summary>
    public class TrueFalseQuestion : Question
    {
        private bool _isTrue;

        /// <summary>
        /// Whether the statement is true or false - demonstrates Encapsulation
        /// </summary>
        public bool IsTrue
        {
            get => _isTrue;
            set
            {
                _isTrue = value;
                // Update the correct answer based on the boolean value
                CorrectAnswer = value ? "True" : "False";
            }
        }

        /// <summary>
        /// Question type identifier
        /// </summary>
        public override string QuestionType => "True/False";

        /// <summary>
        /// Constructor for True/False Question
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="questionText">The statement to evaluate</param>
        /// <param name="isTrue">Whether the statement is true or false</param>
        public TrueFalseQuestion(int id, string questionText, bool isTrue)
            : base(id, questionText, isTrue ? "True" : "False")
        {
            IsTrue = isTrue;
        }

        /// <summary>
        /// Check if the provided answer is correct - implements abstract method
        /// </summary>
        /// <param name="userAnswer">The user's answer (True/False, T/F, 1/0, Yes/No)</param>
        /// <returns>True if correct, false otherwise</returns>
        public override bool IsAnswerCorrect(string userAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            string normalizedAnswer = userAnswer.Trim().ToLowerInvariant();

            // Parse various true representations
            bool userAnswerBool = normalizedAnswer switch
            {
                "true" or "t" or "1" or "yes" or "y" => true,
                "false" or "f" or "0" or "no" or "n" => false,
                _ => throw new ArgumentException($"Invalid answer format: {userAnswer}. Please use True/False, T/F, 1/0, or Yes/No.")
            };

            return userAnswerBool == IsTrue;
        }



        /// <summary>
        /// Get formatted display text with True/False options
        /// </summary>
        /// <returns>Question with True/False options</returns>
        public override string GetDisplayText()
        {
            return base.GetDisplayText() + "\n1. True\n2. False";
        }


    }
}
