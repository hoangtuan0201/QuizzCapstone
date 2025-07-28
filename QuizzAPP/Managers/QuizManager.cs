using System;
using System.Collections.Generic;
using System.Linq;
using QuizzAPP.Models;

namespace QuizzAPP.Managers
{
    /// <summary>
    /// Manages quiz questions and game logic - demonstrates Encapsulation
    /// </summary>
    public class QuizManager
    {
        private List<Question> _questions;
        private int _nextQuestionId;

        /// <summary>
        /// Read-only access to questions list - demonstrates Encapsulation
        /// </summary>
        public IReadOnlyList<Question> Questions => _questions.AsReadOnly();

        /// <summary>
        /// Total number of questions in the quiz
        /// </summary>
        public int QuestionCount => _questions.Count;

        /// <summary>
        /// Event fired when a question is added, updated, or removed
        /// </summary>
        public event EventHandler<QuestionEventArgs>? QuestionChanged;

        /// <summary>
        /// Constructor initializes empty question list
        /// </summary>
        public QuizManager()
        {
            _questions = new List<Question>();
            _nextQuestionId = 1;
        }

        /// <summary>
        /// Add a new question to the quiz
        /// </summary>
        /// <param name="question">Question to add</param>
        /// <returns>The assigned question ID</returns>
        public int AddQuestion(Question question)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question));

            // Assign new ID if not set or if ID already exists
            if (question.Id <= 0 || _questions.Any(q => q.Id == question.Id))
            {
                question.Id = _nextQuestionId++;
            }
            else
            {
                // Update next ID if the provided ID is higher
                _nextQuestionId = Math.Max(_nextQuestionId, question.Id + 1);
            }

            _questions.Add(question);
            OnQuestionChanged(new QuestionEventArgs(question, QuestionChangeType.Added));
            
            return question.Id;
        }

        /// <summary>
        /// Remove a question by ID
        /// </summary>
        /// <param name="questionId">ID of question to remove</param>
        /// <returns>True if removed, false if not found</returns>
        public bool RemoveQuestion(int questionId)
        {
            var question = _questions.FirstOrDefault(q => q.Id == questionId);
            if (question == null)
                return false;

            _questions.Remove(question);
            OnQuestionChanged(new QuestionEventArgs(question, QuestionChangeType.Removed));
            return true;
        }

        /// <summary>
        /// Update an existing question
        /// </summary>
        /// <param name="updatedQuestion">Updated question data</param>
        /// <returns>True if updated, false if not found</returns>
        public bool UpdateQuestion(Question updatedQuestion)
        {
            if (updatedQuestion == null)
                throw new ArgumentNullException(nameof(updatedQuestion));

            var existingIndex = _questions.FindIndex(q => q.Id == updatedQuestion.Id);
            if (existingIndex == -1)
                return false;

            _questions[existingIndex] = updatedQuestion;
            OnQuestionChanged(new QuestionEventArgs(updatedQuestion, QuestionChangeType.Updated));
            return true;
        }

        /// <summary>
        /// Get a question by ID
        /// </summary>
        /// <param name="questionId">Question ID</param>
        /// <returns>Question if found, null otherwise</returns>
        public Question? GetQuestion(int questionId)
        {
            return _questions.FirstOrDefault(q => q.Id == questionId);
        }

        /// <summary>
        /// Get questions by type
        /// </summary>
        /// <param name="questionType">Type of questions to retrieve</param>
        /// <returns>List of questions of the specified type</returns>
        public List<Question> GetQuestionsByType(string questionType)
        {
            return _questions.Where(q => q.QuestionType.Equals(questionType, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// Clear all questions
        /// </summary>
        public void ClearAllQuestions()
        {
            var removedQuestions = _questions.ToList();
            _questions.Clear();
            _nextQuestionId = 1;

            foreach (var question in removedQuestions)
            {
                OnQuestionChanged(new QuestionEventArgs(question, QuestionChangeType.Removed));
            }
        }

        /// <summary>
        /// Get questions in random order for playing
        /// </summary>
        /// <returns>Shuffled list of questions</returns>
        public List<Question> GetShuffledQuestions()
        {
            var shuffled = _questions.ToList();
            var random = new Random();
            
            // Fisher-Yates shuffle algorithm
            for (int i = shuffled.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (shuffled[i], shuffled[j]) = (shuffled[j], shuffled[i]);
            }
            
            return shuffled;
        }

        /// <summary>
        /// Check if quiz has questions and is ready to play
        /// </summary>
        /// <returns>True if quiz can be played</returns>
        public bool IsReadyToPlay()
        {
            return _questions.Count > 0;
        }

        /// <summary>
        /// Get summary statistics about the quiz
        /// </summary>
        /// <returns>Quiz statistics</returns>
        public QuizStatistics GetStatistics()
        {
            return new QuizStatistics
            {
                TotalQuestions = _questions.Count,
                MultipleChoiceCount = _questions.OfType<MultipleChoiceQuestion>().Count(),
                OpenEndedCount = _questions.OfType<OpenEndedQuestion>().Count(),
                TrueFalseCount = _questions.OfType<TrueFalseQuestion>().Count()
            };
        }

        /// <summary>
        /// Fire the QuestionChanged event
        /// </summary>
        /// <param name="args">Event arguments</param>
        protected virtual void OnQuestionChanged(QuestionEventArgs args)
        {
            QuestionChanged?.Invoke(this, args);
        }
    }

    /// <summary>
    /// Event arguments for question changes
    /// </summary>
    public class QuestionEventArgs : EventArgs
    {
        public Question Question { get; }
        public QuestionChangeType ChangeType { get; }

        public QuestionEventArgs(Question question, QuestionChangeType changeType)
        {
            Question = question;
            ChangeType = changeType;
        }
    }

    /// <summary>
    /// Types of question changes
    /// </summary>
    public enum QuestionChangeType
    {
        Added,
        Updated,
        Removed
    }

    /// <summary>
    /// Quiz statistics data
    /// </summary>
    public class QuizStatistics
    {
        public int TotalQuestions { get; set; }
        public int MultipleChoiceCount { get; set; }
        public int OpenEndedCount { get; set; }
        public int TrueFalseCount { get; set; }
    }
}
