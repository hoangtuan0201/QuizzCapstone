using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizzAPP.Models
{
    /// <summary>
    /// Multiple choice question implementation - demonstrates Inheritance
    /// </summary>
    public class MultipleChoiceQuestion : Question
    {
        private List<string> _options = new List<string>();
        private int _correctOptionIndex;

        /// <summary>
        /// List of answer options (4 options required)
        /// </summary>
        public List<string> Options
        {
            get => _options;
            set
            {
                if (value == null || value.Count != 4)
                    throw new ArgumentException("Multiple choice questions must have exactly 4 options.");
                _options = value;
            }
        }

        /// <summary>
        /// Index of the correct option (0-3)
        /// </summary>
        public int CorrectOptionIndex
        {
            get => _correctOptionIndex;
            set
            {
                if (value < 0 || value > 3)
                    throw new ArgumentOutOfRangeException(nameof(value), "Correct option index must be between 0 and 3.");
                _correctOptionIndex = value;
            }
        }

        /// <summary>
        /// Question type identifier
        /// </summary>
        public override string QuestionType => "Multiple Choice";

        /// <summary>
        /// Constructor for Multiple Choice Question
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="questionText">The question text</param>
        /// <param name="options">List of 4 answer options</param>
        /// <param name="correctOptionIndex">Index of correct option (0-3)</param>
        public MultipleChoiceQuestion(int id, string questionText, List<string> options, int correctOptionIndex)
            : base(id, questionText, "")
        {
            Options = options;
            CorrectOptionIndex = correctOptionIndex;
            // Set the correct answer to the text of the correct option
            CorrectAnswer = options[correctOptionIndex];
        }

        /// <summary>
        /// Check if the provided answer is correct - implements abstract method
        /// </summary>
        /// <param name="userAnswer">The user's selected option (as string or index)</param>
        /// <returns>True if correct, false otherwise</returns>
        public override bool IsAnswerCorrect(string userAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            // Try to parse as index first (0, 1, 2, 3)
            if (int.TryParse(userAnswer.Trim(), out int selectedIndex))
            {
                return selectedIndex == CorrectOptionIndex;
            }

            // Try to match the actual text of the option
            string normalizedUserAnswer = userAnswer.Trim().ToLowerInvariant();
            string normalizedCorrectAnswer = CorrectAnswer.Trim().ToLowerInvariant();
            
            return normalizedUserAnswer == normalizedCorrectAnswer;
        }

        /// <summary>
        /// Get formatted display text with options
        /// </summary>
        /// <returns>Question with numbered options</returns>
        public override string GetDisplayText()
        {
            var displayText = base.GetDisplayText() + "\n";
            for (int i = 0; i < Options.Count; i++)
            {
                displayText += $"{i + 1}. {Options[i]}\n";
            }
            return displayText.TrimEnd();
        }

        /// <summary>
        /// Get option by index (1-based for display)
        /// </summary>
        /// <param name="index">1-based index</param>
        /// <returns>Option text</returns>
        public string GetOption(int index)
        {
            if (index < 1 || index > 4)
                throw new ArgumentOutOfRangeException(nameof(index), "Option index must be between 1 and 4.");
            
            return Options[index - 1];
        }

        /// <summary>
        /// Check if answer by 1-based index is correct
        /// </summary>
        /// <param name="selectedIndex">1-based index (1, 2, 3, 4)</param>
        /// <returns>True if correct</returns>
        public bool IsAnswerCorrectByIndex(int selectedIndex)
        {
            return selectedIndex - 1 == CorrectOptionIndex;
        }
    }
}
