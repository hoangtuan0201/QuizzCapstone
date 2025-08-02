using System;
using System.Collections.Generic;
using System.Linq;
using QuizzAPP.Models;

namespace QuizzAPP.Managers
{
    // Tính toán và quản lý điểm số quiz
    public class ScoreManager
    {
        private List<QuestionResult> _results;
        public IReadOnlyList<QuestionResult> Results
        {
            get { return _results.AsReadOnly(); }
        }

        // Tổng số câu hỏi đã trả lời
        public int TotalQuestions
        {
            get { return _results.Count; }
        }

        // Số câu trả lời đúng
        public int CorrectAnswers
        {
            get { return _results.Count(r => { return r.IsCorrect; }); }
        }

        // Số câu trả lời sai
        public int IncorrectAnswers
        {
            get { return _results.Count(r => { return !r.IsCorrect; }); }
        }

        // Điểm số theo phần trăm (0-100)
        public double ScorePercentage
        {
            get { return TotalQuestions > 0 ? (double)CorrectAnswers / TotalQuestions * 100 : 0; }
        }

        // Điểm số dạng phân số (VD: "8/10")
        public string ScoreFraction
        {
            get { return $"{CorrectAnswers}/{TotalQuestions}"; }
        }

        // Xếp loại theo chữ cái
        public string LetterGrade
        {
            get { return GetLetterGrade(ScorePercentage); }
        }

        // Constructor
        public ScoreManager()
        {
            _results = new List<QuestionResult>();
        }

        // Ghi lại kết quả trả lời câu hỏi
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

        // Xóa tất cả kết quả đã ghi
        public void Reset()
        {
            _results.Clear();
        }

        // Lấy kết quả theo loại câu hỏi
        public List<QuestionResult> GetResultsByType(string questionType)
        {
            return _results.Where(r =>
            {
                return r.Question.QuestionType.Equals(questionType, StringComparison.OrdinalIgnoreCase);
            }).ToList();
        }

        // Lấy phân tích điểm chi tiết theo loại câu hỏi
        public ScoreBreakdown GetScoreBreakdown()
        {
            var breakdown = new ScoreBreakdown();

            var multipleChoiceResults = GetResultsByType("Multiple Choice");
            var openEndedResults = GetResultsByType("Open Ended");
            var trueFalseResults = GetResultsByType("True/False");

            breakdown.MultipleChoice = new TypeScore
            {
                Correct = multipleChoiceResults.Count(r => { return r.IsCorrect; }),
                Total = multipleChoiceResults.Count
            };

            breakdown.OpenEnded = new TypeScore
            {
                Correct = openEndedResults.Count(r => { return r.IsCorrect; }),
                Total = openEndedResults.Count
            };

            breakdown.TrueFalse = new TypeScore
            {
                Correct = trueFalseResults.Count(r => { return r.IsCorrect; }),
                Total = trueFalseResults.Count
            };

            breakdown.Overall = new TypeScore
            {
                Correct = CorrectAnswers,
                Total = TotalQuestions
            };

            return breakdown;
        }

        


        // Chuyển đổi phần trăm thành xếp loại chữ cái
        private string GetLetterGrade(double percentage)
        {
            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";
            }
            else if (percentage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }

    // Kết quả trả lời một câu hỏi
    public class QuestionResult
    {
        public Question Question { get; set; } = null!;
        public string UserAnswer { get; set; } = string.Empty;
        public bool IsCorrect { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public DateTime AnsweredAt { get; set; }
    }

    // Phân tích điểm theo loại câu hỏi
    public class ScoreBreakdown
    {
        public TypeScore MultipleChoice { get; set; } = new();
        public TypeScore OpenEnded { get; set; } = new();
        public TypeScore TrueFalse { get; set; } = new();
        public TypeScore Overall { get; set; } = new();
    }

    // Điểm số cho một loại câu hỏi cụ thể
    public class TypeScore
    {
        public int Correct { get; set; }
        public int Total { get; set; }
        public double Percentage
        {
            get { return Total > 0 ? (double)Correct / Total * 100 : 0; }
        }
        public string Fraction
        {
            get { return $"{Correct}/{Total}"; }
        }
    }
}

/*
 * GIẢI THÍCH VỀ LỚP SCORECALCULATOR:
 *
 * 1. TÍNH TOÁN ĐIỂM SỐ (Score Calculation):
 *    - Tự động tính điểm theo phần trăm và phân số
 *    - Xếp loại theo thang điểm A, B, C, D, F
 *    - Theo dõi số câu đúng/sai real-time
 *
 * 2. QUẢN LÝ KẾT QUẢ (Result Management):
 *    - Lưu trữ kết quả từng câu hỏi trong List<QuestionResult>
 *    - Ghi lại thời gian trả lời, đáp án user, đáp án đúng
 *    - Cung cấp IReadOnlyList để bảo vệ dữ liệu
 *
 * 3. PHÂN TÍCH CHI TIẾT (Detailed Analysis):
 *    - GetScoreBreakdown(): Phân tích theo loại câu hỏi
 *    - GetResultsByType(): Lọc kết quả theo loại
 *    - TypeScore class: Tính điểm riêng cho từng loại
 *
 * 4. HELPER CLASSES:
 *    - QuestionResult: Lưu kết quả 1 câu hỏi
 *    - ScoreBreakdown: Tổng hợp điểm theo loại
 *    - TypeScore: Điểm số + phần trăm + phân số
 *
 * 5. TÍNH NĂNG CHÍNH:
 *    - RecordAnswer(): Ghi lại kết quả trả lời
 *    - Reset(): Xóa tất cả kết quả để bắt đầu lại
 *    - Properties tự động tính toán: ScorePercentage, LetterGrade
 *    - Hỗ trợ multiple question types với logic riêng biệt
 */
