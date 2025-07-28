using System;
using System.Collections.Generic;
using System.Linq;
using QuizzAPP.Models;

namespace QuizzAPP.Managers
{
    // Quản lý câu hỏi và logic game
    public class QuizManager
    {
        private List<Question> _questions;
        private int _nextQuestionId;

        // Danh sách câu hỏi (chỉ đọc)
        public IReadOnlyList<Question> Questions
        {
            get { return _questions.AsReadOnly(); }
        }

        // Tổng số câu hỏi
        public int QuestionCount
        {
            get { return _questions.Count; }
        }

        // Event khi có thay đổi câu hỏi (thêm, sửa, xóa)
        public event EventHandler<QuestionEventArgs>? QuestionChanged;

        // Constructor
        public QuizManager()
        {
            _questions = new List<Question>();
            _nextQuestionId = 1;
        }

        // Thêm câu hỏi mới vào quiz
        public int AddQuestion(Question question)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question));

            // Assign new ID if not set or if ID already exists
            if (question.Id <= 0 || _questions.Any(q =>
            {
                return q.Id == question.Id;
            }))
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

        // Xóa câu hỏi theo ID
        public bool RemoveQuestion(int questionId)
        {
            var question = _questions.FirstOrDefault(q =>
            {
                return q.Id == questionId;
            });
            if (question == null)
                return false;

            _questions.Remove(question);
            OnQuestionChanged(new QuestionEventArgs(question, QuestionChangeType.Removed));
            return true;
        }

        // Cập nhật câu hỏi hiện có
        public bool UpdateQuestion(Question updatedQuestion)
        {
            if (updatedQuestion == null)
                throw new ArgumentNullException(nameof(updatedQuestion));

            var existingIndex = _questions.FindIndex(q =>
            {
                return q.Id == updatedQuestion.Id;
            });
            if (existingIndex == -1)
                return false;

            _questions[existingIndex] = updatedQuestion;
            OnQuestionChanged(new QuestionEventArgs(updatedQuestion, QuestionChangeType.Updated));
            return true;
        }

        // Lấy câu hỏi theo ID
        public Question? GetQuestion(int questionId)
        {
            return _questions.FirstOrDefault(q =>
            {
                return q.Id == questionId;
            });
        }

        // Lấy câu hỏi theo loại
        public List<Question> GetQuestionsByType(string questionType)
        {
            return _questions.Where(q =>
            {
                return q.QuestionType.Equals(questionType, StringComparison.OrdinalIgnoreCase);
            }).ToList();
        }

        // Xóa tất cả câu hỏi
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

        // Lấy câu hỏi theo thứ tự ngẫu nhiên để chơi
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

        // Kiểm tra quiz có sẵn sàng chơi không
        public bool IsReadyToPlay()
        {
            return _questions.Count > 0;
        }

        // Lấy thống kê tổng quan về quiz
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

        // Kích hoạt event QuestionChanged
        protected virtual void OnQuestionChanged(QuestionEventArgs args)
        {
            QuestionChanged?.Invoke(this, args);
        }
    }

    // Event arguments cho thay đổi câu hỏi
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

    // Các loại thay đổi câu hỏi
    public enum QuestionChangeType
    {
        Added,
        Updated,
        Removed
    }

    // Dữ liệu thống kê quiz
    public class QuizStatistics
    {
        public int TotalQuestions { get; set; }
        public int MultipleChoiceCount { get; set; }
        public int OpenEndedCount { get; set; }
        public int TrueFalseCount { get; set; }
    }
}

/*
 * GIẢI THÍCH VỀ LỚP QUIZMANAGER:
 *
 * 1. QUẢN LÝ DỮ LIỆU (Data Management):
 *    - Sử dụng List<Question> để lưu trữ câu hỏi trong memory
 *    - Tự động tạo ID cho câu hỏi mới (_nextQuestionId)
 *    - Cung cấp IReadOnlyList để bảo vệ dữ liệu khỏi thay đổi trực tiếp
 *
 * 2. CRUD OPERATIONS:
 *    - AddQuestion(): Thêm câu hỏi mới với validation
 *    - UpdateQuestion(): Cập nhật câu hỏi hiện có
 *    - RemoveQuestion(): Xóa câu hỏi theo ID
 *    - GetQuestion(): Lấy câu hỏi theo ID
 *    - ClearAllQuestions(): Xóa tất cả câu hỏi
 *
 * 3. EVENT SYSTEM:
 *    - QuestionChanged event thông báo khi có thay đổi
 *    - QuestionEventArgs chứa thông tin về thay đổi
 *    - QuestionChangeType enum: Added, Updated, Removed
 *    - UI có thể subscribe để cập nhật real-time
 *
 * 4. GAME FEATURES:
 *    - GetShuffledQuestions(): Trộn câu hỏi ngẫu nhiên cho game
 *    - IsReadyToPlay(): Kiểm tra có thể chơi không
 *    - GetQuestionsByType(): Lọc theo loại câu hỏi
 *    - GetStatistics(): Thống kê tổng quan
 *
 * 5. DESIGN PATTERNS:
 *    - Observer Pattern: Event system cho UI updates
 *    - Repository Pattern: Quản lý collection của Question
 *    - Encapsulation: Private fields với public properties
 *    - Single Responsibility: Chỉ quản lý câu hỏi và logic liên quan
 */
