using System;

namespace QuizzAPP.Models
{
    /// <summary>
    /// Abstract base class for all question types - demonstrates Abstraction and Inheritance
    /// </summary>
    public abstract class Question
    {
        private string _questionText = string.Empty;
        private string _correctAnswer = string.Empty;
        private int _id;

        /// <summary>
        /// Unique identifier for the question - demonstrates Encapsulation
        /// </summary>
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        /// <summary>
        /// The question text - demonstrates Encapsulation
        /// </summary>
        public string QuestionText
        {
            get => _questionText;
            set => _questionText = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// The correct answer - demonstrates Encapsulation
        /// </summary>
        public string CorrectAnswer
        {
            get => _correctAnswer;
            set => _correctAnswer = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Type of question (Multiple Choice, Open Ended, True/False)
        /// </summary>
        public abstract string QuestionType { get; }

        /// <summary>
        /// Constructor for Question base class
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="questionText">The question text</param>
        /// <param name="correctAnswer">The correct answer</param>
        protected Question(int id, string questionText, string correctAnswer)
        {
            Id = id;
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
        }

        /// <summary>
        /// Abstract method to check if the provided answer is correct - demonstrates Abstraction
        /// </summary>
        /// <param name="userAnswer">The user's answer</param>
        /// <returns>True if correct, false otherwise</returns>
        public abstract bool IsAnswerCorrect(string userAnswer);

        /// <summary>
        /// Virtual method to get display text for the question
        /// </summary>
        /// <returns>Formatted question text</returns>
        public virtual string GetDisplayText()
        {
            return $"Q{Id}: {QuestionText}";
        }

        /// <summary>
        /// Override ToString for debugging and display purposes
        /// </summary>
        /// <returns>String representation of the question</returns>
        public override string ToString()
        {
            return $"{QuestionType} - {QuestionText}";
        }
    }
}
