using System;
using System.Collections.Generic;
using System.Linq;
using QuizzAPP.Models;

namespace QuizzAPP.Managers
{
    // Tính toán và quản lý điểm số quiz - Gộp cả QuestionResult vào
    public class ScoreManager
    {
        // Inner class để lưu kết quả từng câu hỏi
        public class QuestionResult
        {
            public Question Question { get; set; } = null!;
            public string UserAnswer { get; set; } = string.Empty;
            public bool IsCorrect { get; set; }
        }

        private List<QuestionResult> _results;
    
        // Danh sách kết quả câu hỏi (chỉ đọc)
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
            get { return _results.Count(r => r.IsCorrect); }
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
                IsCorrect = isCorrect
            };
            _results.Add(result);
        }

        // Chuyển đổi phần trăm thành xếp loại chữ cái
        private string GetLetterGrade(double percentage)
        {
            if (percentage >= 90) return "A";
            if (percentage >= 80) return "B";
            if (percentage >= 70) return "C";
            if (percentage >= 60) return "D";
            return "F";
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
