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
        /// Check if answer is correct using boolean value
        /// </summary>
        /// <param name="userAnswer">Boolean answer</param>
        /// <returns>True if correct</returns>
        public bool IsAnswerCorrect(bool userAnswer)
        {
            return userAnswer == IsTrue;
        }

        /// <summary>
        /// Get formatted display text with True/False options
        /// </summary>
        /// <returns>Question with True/False options</returns>
        public override string GetDisplayText()
        {
            return base.GetDisplayText() + "\n1. True\n2. False";
        }

        /// <summary>
        /// Get the opposite answer (for generating wrong options)
        /// </summary>
        /// <returns>The incorrect answer</returns>
        public string GetIncorrectAnswer()
        {
            return IsTrue ? "False" : "True";
        }

        /// <summary>
        /// Validate answer format without checking correctness
        /// </summary>
        /// <param name="answer">Answer to validate</param>
        /// <returns>True if format is valid</returns>
        public bool IsAnswerFormatValid(string answer)
        {
            if (string.IsNullOrWhiteSpace(answer))
                return false;

            string normalizedAnswer = answer.Trim().ToLowerInvariant();
            
            return normalizedAnswer is "true" or "false" or "t" or "f" or 
                   "1" or "0" or "yes" or "no" or "y" or "n";
        }

        /// <summary>
        /// Convert string answer to boolean
        /// </summary>
        /// <param name="answer">String answer</param>
        /// <returns>Boolean representation</returns>
        /// <exception cref="ArgumentException">If answer format is invalid</exception>
        public bool ParseAnswerToBool(string answer)
        {
            if (string.IsNullOrWhiteSpace(answer))
                throw new ArgumentException("Answer cannot be null or empty.");

            string normalizedAnswer = answer.Trim().ToLowerInvariant();

            return normalizedAnswer switch
            {
                "true" or "t" or "1" or "yes" or "y" => true,
                "false" or "f" or "0" or "no" or "n" => false,
                _ => throw new ArgumentException($"Invalid answer format: {answer}")
            };
        }
    }
}
